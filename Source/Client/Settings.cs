using System;
using System.Windows.Forms;

namespace Client
{
    public partial class Settings : Form
    {
        private MainForm mainform;
        private string solver = "dll";

        public Settings(MainForm form)
        {
            InitializeComponent();
            mainform = form;
            directoryTBox.Text = mainform.Savedirectory;
            streamTBox.Text = mainform.Streamsize.ToString();
            portTBox.Text = mainform.Port.ToString();
            string[] splittedAddress = mainform.Address.Split('.');
            ip1TBox.Text = splittedAddress[0];
            ip2TBox.Text = splittedAddress[1];
            ip3TBox.Text = splittedAddress[2];
            ip4TBox.Text = splittedAddress[3];
            solver = mainform.Solver;
            
            if (mainform.WindowedServer)
                windowCheckBox.Checked = true;
            else
                windowCheckBox.Checked = false;

            if (solver == "server")
                ServerRButton.Checked = true;
            else if (solver == "dll")
                DLLRButton.Checked = true;
            else
                MatLabRButton.Checked = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                directoryTBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            mainform.Address = ip1TBox.Text + "." + ip2TBox.Text + "." + ip3TBox.Text + "." + ip4TBox.Text;
            mainform.Port = int.Parse(portTBox.Text);
            mainform.Streamsize = int.Parse(streamTBox.Text);
            mainform.Savedirectory = directoryTBox.Text;
            mainform.Solver = solver;
            if (windowCheckBox.Checked)
                mainform.WindowedServer = true;
            else
                mainform.WindowedServer = false;
            Close();
        }

        private void DLLRButton_CheckedChanged(object sender, EventArgs e)
        {
            solver = "dll";
        }

        private void ServerRButton_CheckedChanged(object sender, EventArgs e)
        {
            solver = "server";
        }

        private void MatLabRButton_CheckedChanged(object sender, EventArgs e)
        {
            solver = "matlab";
        }
    }
}
