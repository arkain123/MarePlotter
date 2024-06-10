using System;
using System.Windows.Forms;

namespace ServerForm
{
    internal class Loger
    {
        private RichTextBox logTbox;

        public Loger(RichTextBox logtextbox)
        {
            logTbox = logtextbox;
        }

        public void LogError(Exception e)
        {
            string log = DateTime.Now.ToString() + " (ERROR): " + e.ToString() + "\n";
            logTbox.Text += log;
        }

        public void Log(string msg)
        {
            string log = DateTime.Now.ToString() + " (LOG): " + msg + "\n";
            logTbox.Text += log;
        }

        public void Clear()
        {
            logTbox.Text = "";
        }

        public void LogStop()
        {
            string log = "--------------------------STOPPED--------------------------";
            logTbox.Text += log;
        }

        public void LogStart()
        {
            string log = "--------------------------STARTED--------------------------" + "\n";
            logTbox.Text += log;
        }
    }
}
