using System;
using System.Diagnostics;
using System.Drawing;
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

        private void MOON(object sender, EventArgs e)
        {
            Color buttonColor = button1.BackColor == SystemColors.Control ? SystemColors.ControlDark : SystemColors.Control;
            button1.BackColor = buttonColor;
            button2.BackColor = buttonColor;
            button3.BackColor = buttonColor;
            button4.BackColor = buttonColor;
            button5.BackColor = buttonColor;

            Color formColor = this.BackColor == Color.Black ? Color.White : Color.Black;
            this.BackColor = formColor;

            Color buttonTextColor = button1.ForeColor == Color.DeepSkyBlue ? Color.White : Color.DeepSkyBlue;
            button1.ForeColor = buttonTextColor;
            button2.ForeColor = buttonTextColor;
            button3.ForeColor = buttonTextColor;
            button4.ForeColor = buttonTextColor;
            button5.ForeColor = buttonTextColor;
        }
    }
}
