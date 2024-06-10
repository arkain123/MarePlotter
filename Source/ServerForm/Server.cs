using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace ServerForm
{
    public partial class Server : Form
    {
        private string address = "127.0.0.1";
        private int port = 11208;
        private bool started = false;
        private TCPServer server;
        private CancellationTokenSource cancellationTokenSource;
        private Loger loger;

        public string Address
        {
            get { return address; }
        }

        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        public Server()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
            loger = new Loger(richTextBox1);
            server = new TCPServer(loger);
    }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (started)
            {
                OnlineBar.Value = 0;
                portTBox.Enabled = true;
                StartButton.Text = "Запустить";
                started = false;
                loger.LogStop();

                cancellationTokenSource.Cancel();
                server.StopServer();
            }
            else
            {
                OnlineBar.Value = 1;
                portTBox.Enabled = false;
                StartButton.Text = "Остановить";
                started = true;
                richTextBox1.Clear();
                loger.LogStart();

                Port = int.Parse(portTBox.Text);
                cancellationTokenSource = new CancellationTokenSource();
                backgroundWorker1.RunWorkerAsync(cancellationTokenSource.Token);
            }
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            CancellationToken cancellationToken = (CancellationToken)e.Argument;
            server.StartServer(Port, cancellationToken);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
                server.StopServer();
            }
            else
            {
                server.StopServer();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Title = "Save text to file";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                try
                {
                    File.WriteAllText(filePath, richTextBox1.Text);
                    MessageBox.Show("Лог успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
