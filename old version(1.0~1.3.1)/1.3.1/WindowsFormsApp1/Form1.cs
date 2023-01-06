using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void One(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("c:");
            cmd.StandardInput.WriteLine("cd %USERPROFILE%/AppData/Roaming");
            cmd.StandardInput.WriteLine("ren EldenRing ERSCT_Saves_1(Don't_move)");
            cmd.StandardInput.WriteLine("mkdir EldenRing");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            MessageBox.Show("完成", "清除當前存檔");
        }

        private void Two(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("c:");
            cmd.StandardInput.WriteLine("cd %USERPROFILE%/AppData/Roaming");
            cmd.StandardInput.WriteLine("if not exist \"EldenRing\" mkdir \"EldenRing\"");
            cmd.StandardInput.WriteLine("if not exist \"ERSCT_Saves_1(Don't_move)\" mkdir \"ERSCT_Saves_1(Don't_move)\"");
            cmd.StandardInput.WriteLine("ren EldenRing ERSCT_Saves_2(Don't_move)");
            cmd.StandardInput.WriteLine("ren ERSCT_Saves_1(Don't_move) EldenRing");
            cmd.StandardInput.WriteLine("ren ERSCT_Saves_2(Don't_move) ERSCT_Saves_1(Don't_move)");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            MessageBox.Show("完成", "轉換存檔");
        }

        private void Three(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("start https://hongyihanksblog.ml/ERSCT");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        private void Four(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("cd %AppData%");
            cmd.StandardInput.WriteLine("start EldenRing");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
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
        private bool _isEnglish = true;
        private void EN(object sender, EventArgs e)
        {
            _isEnglish = !_isEnglish;
            if (_isEnglish)
            {
                button1.Text = "清除當前存檔";
                button4.Text = "轉換存檔";
                button3.Text = "查看操作說明";
                button2.Text = "打開存檔位置";
                button5.Text = "離開";
            }
            else
            {
                button1.Text = "Clean the saves";
                button4.Text = "Change the saves";
                button3.Text = "View Operation Instructions";
                button2.Text = "Open the saves path";
                button5.Text = "Exit";
            }
            if (this.Text == "Elden Ring Saves Change Tool")
            {
                this.Text = "艾爾登法環存檔轉換工具";
            }
            else
            {
                this.Text = "Elden Ring Saves Change Tool";
            }
        }
    }
}
