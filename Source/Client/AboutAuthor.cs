using System.Windows.Forms;

namespace Client
{
    public partial class AboutAuthor : Form
    {
        public AboutAuthor()
        {
            InitializeComponent();
            GithubLinkLabel.LinkVisited = false;
        }

        private void GithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GithubLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/arkain123");
        }
    }
}
