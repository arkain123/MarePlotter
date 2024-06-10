using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using DLL;

namespace Client
{
    public partial class MainForm : Form
    {
        private double t0 = 0;
        private double y0 = 0.5;
        private double h = 0.1;
        private double tf = 0.5;
        private string usereq = "y - x * x + 1";
        private string address = "127.0.0.1";
        private int port = 11208;
        private string savedirectory = "Не указан";
        private int streamsize = 4096;
        private bool windowedServer = true;
        private string[] data = new string[1];
        private string solver = "dll";

        public string Solver
        {
            get { return solver; }
            set { solver = value; }
        }

        public bool WindowedServer
        {
            get { return windowedServer; }
            set { windowedServer = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        public string Savedirectory
        {
            get { return savedirectory; }
            set { savedirectory = value; }
        }

        public int Streamsize
        {
            get { return streamsize; }
            set { streamsize = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            data[0] = "solving";
        }

        public void GetValues()
        {
            try
            {
                t0 = Convert.ToDouble(t0TextBox.Text);
                y0 = Convert.ToDouble(y0TextBox.Text);
                h = Convert.ToDouble(hTextBox.Text);
                tf = Convert.ToDouble(tfTextBox.Text);
                usereq = eqTextBox.Text;
                if (eqTextBox.Text == "")
                {
                    throw new Exception("Incorrect equation");
                }
            }
            catch (Exception ex)
            {
                t0 = 0;
                y0 = 0.5;
                h = 0.1;
                tf = 0.5;
                usereq = "y - x * x + 1";
                tfTextBox.Text = "0,5";
                hTextBox.Text = "0,1";
                y0TextBox.Text = "0,5";
                t0TextBox.Text = "0";
                eqTextBox.Text = usereq;
                MessageBox.Show("Введите корректные значения");
            }
        }

        private void CheckSolver()
        {
            if (solver == "server")
            {
                TCPClient client = new TCPClient();
                string msg = t0 + "~" + y0 + "~" + h + "~" + tf + "~" + usereq;
                data = client.Handshake(msg, Address, Port, Streamsize);
            } 
            else if (solver == "dll")
            {
                Algorithm algo = new Algorithm();
                algo.SetValues(t0, y0, h, tf, usereq);
                data = algo.Solve();
            }
            else if (solver == "matlab")
            {
                MLApp.MLApp matlab = new MLApp.MLApp();
                matlab.Visible = 0;
                MatLabSolver matlabsolver = new MatLabSolver();
                data = new string[1];
                data[0] = matlabsolver.RunCalculation(matlab, y0, t0, tf, h, usereq);
            }
            else
            {
                data[0] = "System.Net.Sockets.SocketException";
            }
        }

        private void Solve()
        {
            try
            {
                double result = double.Parse(data[data.Length - 1], CultureInfo.InvariantCulture);
                ResultLabel.Text = "Результат: Y = " + result;
                try
                {
                    Graphic graph = new Graphic(data, mainChart, dataGridView1);
                    graph.Visualise();
                }
                catch (Exception ex) { }
            }
            catch (Exception ex)
            {
                ResultLabel.Text = "Результат не определен";
                mainChart.Series[0].Points.Clear();
                dataGridView1.Rows.Clear();
            }
        }

        private bool ErrHandler()
        {
            if (data[0] == "System.Net.Sockets.SocketException")
            {
                errlabel.Text = "Ошибка соединения с сервером";
                return true;
            }
            if (data[0] == "System.IO.IOException")
            {
                errlabel.Text = "Удалённый хост разорвал подключение";
                return true;
            }
            return false;
        }

        private void Save()
        {
            string text = null;
            for (int i = 0; i < data.Length; i++)
            {
                text += data[i] + "\n";
            }
            if (Savedirectory != "Не указан")
                System.IO.File.WriteAllText(Savedirectory + "\\saved.txt", text);
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            data = null;
            errlabel.Visible = false;
            GetValues();
            CheckSolver();

            if (ErrHandler())
            {
                errlabel.Visible = true;
            }
            else
            {
                Solve();
            }
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAuthor aboutAuthor = new AboutAuthor();
            aboutAuthor.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.Show();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settings.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void запуститьСерверToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process startServer = new Process();
            if (windowedServer)
                startServer = Process.Start("ServerForm.exe");
            else
                startServer = Process.Start("ServerConsole.exe");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Savedirectory == "" || Savedirectory == "Не указан")
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    Savedirectory = folderBrowserDialog1.SelectedPath;
                } else
                {
                    return;
                }
            }

            Save();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Savedirectory = folderBrowserDialog1.SelectedPath;
            }

            Save();
        }

        private void открытьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            string[] tempdata = fileText.Split('\n');
            data = new string[tempdata.Length - 1];
            for (int i = 0; i < tempdata.Length - 1; i++)
            {
                data[i] = tempdata[i];
            }
            Solve();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            открытьКакToolStripMenuItem_Click(sender, e);
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            сохранитьКакToolStripMenuItem_Click(sender, e);
        }

        private void серверToolStripMenuItem_Click(object sender, EventArgs e)
        {
            запуститьСерверToolStripMenuItem_Click(sender, e);
        }

        private void настройкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            настройкиToolStripMenuItem_Click(sender, e);
        }

        private void экспортВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saver excelSaver = new Saver();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Экспорт в Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    excelSaver.SaveToExcel(saveFileDialog.FileName, data, usereq, t0, y0, h, tf);
                    MessageBox.Show("Файл сохранён успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void экспортВWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saver wordSaver = new Saver();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
            saveFileDialog.Title = "Экспорт в Word";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    wordSaver.SaveToWord(mainChart, saveFileDialog.FileName);
                    MessageBox.Show("Файл сохранён успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            экспортВWordToolStripMenuItem_Click(sender, e);
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            экспортВExcelToolStripMenuItem_Click(sender, e);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpProvider helpProvider1 = new HelpProvider();
            helpProvider1.HelpNamespace = "MareHelper.chm";
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
            helpProvider1.SetHelpKeyword(this, "");

            Help.ShowHelp(this, helpProvider1.HelpNamespace, helpProvider1.GetHelpNavigator(this), helpProvider1.GetHelpKeyword(this));
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            справкаToolStripMenuItem_Click(sender, e);
        }
    }
}
