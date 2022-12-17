using System;
using System.Diagnostics;
using System.Windows.Forms;
using static System.IO.Path;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ExecuteBatFile(string filename)
        {
            string path = Combine(Environment.CurrentDirectory, "cmd", filename);
            Process.Start(path);
        }

        private void One(object sender, EventArgs e)
        {
            ExecuteBatFile("1.bat");
            MessageBox.Show("完成", "清除當前存檔");
        }

        private void Two(object sender, EventArgs e)
        {
            ExecuteBatFile("2.bat");
            MessageBox.Show("完成", "轉換存檔");
        }

        private void Three(object sender, EventArgs e)
        {
            ExecuteBatFile("3.bat");
        }

        private void Four(object sender, EventArgs e)
        {
            ExecuteBatFile("4.bat");
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
