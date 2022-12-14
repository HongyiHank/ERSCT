using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnTest(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "cmd", "1.bat");
            Process.Start(path);
        }

        private void Two(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "cmd", "2.bat");
            Process.Start(path);
        }

        private void Three(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "cmd", "3.bat");
            Process.Start(path);
        }

        private void Four(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "cmd", "4.bat");
            Process.Start(path);
        }

        private void Exit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要退出程式嗎？", "退出", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
