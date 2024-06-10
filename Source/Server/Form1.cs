using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RungeKutta rk = new RungeKutta();
            //тест
            double t0 = 0;
            double y0 = 0.5;
            double h = 0.1;
            double tf = 0.5;

            double result = rk.Solve(t0, y0, h, tf);

            logTextBox.Text = result.ToString();
        }

        public void LogMsg(string msg)
        {
            logTextBox.Text += "\n" += msg;
        }
    }
}
