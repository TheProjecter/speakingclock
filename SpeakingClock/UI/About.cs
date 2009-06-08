using System;
using System.Windows.Forms;

namespace SpeakingClock
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com/coop/cse?cx=009272466982942405396%3Ai6rivvvmkh0");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SpeakTime.SayText("We can't stop here. This is bat country !", 100);
        }
    }
}
