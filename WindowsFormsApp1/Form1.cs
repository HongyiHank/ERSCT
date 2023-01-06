using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 設定圓角按鈕
            button1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));
            button3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            button4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 30, 30));
            button5.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button5.Width, button5.Height, 30, 30));
            // 設定圓角視窗
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            // 設定圓角圖片
            pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 20, 20));
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        private void One(object sender, EventArgs e)// 按鈕一
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

        private void Two(object sender, EventArgs e)// 按鈕二
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

        private void Three(object sender, EventArgs e)// 按鈕三
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

        private void Four(object sender, EventArgs e)// 按鈕四
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("c:");
            cmd.StandardInput.WriteLine("cd %AppData%");
            cmd.StandardInput.WriteLine("start EldenRing");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        private void Exit(object sender, EventArgs e)// 按鈕五
        {
            DialogResult result = MessageBox.Show("確定要退出程式嗎？", "退出", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MOON(object sender, EventArgs e)//改變主題(黑色系與白色系)
        {
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string styleFilePath = Path.Combine(appDataFolder, "Duchie", "ERSCT", "style.txt");

            // 讀取style.txt的內容
            string styleText = File.ReadAllText(styleFilePath);
            int style = int.Parse(styleText);

            // 如果style為1，就改為2；如果style為2，就改為1
            style = (style == 1) ? 2 : 1;

            // 將修改過的style寫回style.txt中
            File.WriteAllText(styleFilePath, style.ToString());

            // 根據style的值改變按鈕和程式的外觀
            if (style == 1)
            {
                foreach (Button button in new Button[] { button1, button2, button3, button4, button5 })
                {
                    button.BackColor = SystemColors.ControlDark;
                    button.ForeColor = Color.White;
                }
                this.BackColor = Color.Black;
            }
            else
            {
                foreach (Button button in new Button[] { button1, button2, button3, button4, button5 })
                {
                    button.BackColor = Color.Gainsboro;
                    button.ForeColor = Color.DeepSkyBlue;
                }
                this.BackColor = Color.White;
            }
        }
        private void EN(object sender, EventArgs e)
        {
            // 取得 %appdata%\Duchie\ERSCT 資料夾中的 lang.txt 的路徑
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Duchie\ERSCT\lang.txt";

            // 讀取 lang.txt 的內容
            string lang = File.ReadAllText(path);

            // 如果 lang.txt 內容為 tch，將其改為 en
            // 如果內容為 en，將其改為 tch
            if (lang == "tch")
            {
                File.WriteAllText(path, "en");
                lang = "en";
            }
            else if (lang == "en")
            {
                File.WriteAllText(path, "tch");
                lang = "tch";
            }

            // 如果 lang.txt 內容為 tch，將 button1~5 的文字內容依序改為 "清除當前存檔" "轉換存檔" "查看操作說明" "打開存檔位置" "離開"
            // 如果內容為 en，將 button1~5 的文字內容依序改為 "Clean saves" "Change saves" "View Operation Instructions" "Open saves path" "Exit"
            if (lang == "tch")
            {
                button1.Text = "清除當前存檔";
                button2.Text = "轉換存檔";
                button3.Text = "查看操作說明";
                button4.Text = "打開存檔位置";
                button5.Text = "離開";
            }
            else if (lang == "en")
            {
                button1.Text = "Clean saves";
                button2.Text = "Change saves";
                button3.Text = "View Operation Instructions";
                button4.Text = "Open saves path";
                button5.Text = "Exit";
            }
        }

        private Point mouseDownPos;
        private void DOWN(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPos = e.Location;
            }
        }

        private void MOVE(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point delta = new Point(e.Location.X - mouseDownPos.X, e.Location.Y - mouseDownPos.Y);
                Point newLocation = new Point(Location.X + delta.X, Location.Y + delta.Y);
                Location = newLocation;
            }
        }

        private void UP(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPos = Point.Empty;
            }
        }

        private void SL(object sender, EventArgs e)
        {
            // 取得 %AppData% 路徑
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // 創建 Duchie 文件夾
            string duchiePath = Path.Combine(appDataPath, "Duchie");
            if (!Directory.Exists(duchiePath))
            {
                Directory.CreateDirectory(duchiePath);
            }

            // 創建 ERSCT 文件夾
            string ersctPath = Path.Combine(duchiePath, "ERSCT");
            if (!Directory.Exists(ersctPath))
            {
                Directory.CreateDirectory(ersctPath);
            }

            // 創建 style.txt
            string stylePath = Path.Combine(ersctPath, "style.txt");
            if (!File.Exists(stylePath))
            {
                File.Create(stylePath).Dispose();
            }



            // 修改 style.txt 文件内容
            string styleContent = File.ReadAllText(stylePath);
            if (string.IsNullOrEmpty(styleContent))
            {
                File.WriteAllText(stylePath, "2");
            }

            // 修改按鈕的字體顏色
            if (styleContent == "1")
            {
                button1.BackColor = SystemColors.ControlDark;
                button2.BackColor = SystemColors.ControlDark;
                button3.BackColor = SystemColors.ControlDark;
                button4.BackColor = SystemColors.ControlDark;
                button5.BackColor = SystemColors.ControlDark;
                button1.ForeColor = Color.White;
                button2.ForeColor = Color.White;
                button3.ForeColor = Color.White;
                button4.ForeColor = Color.White;
                button5.ForeColor = Color.White;
                this.BackColor = Color.Black;
            }
            else if (styleContent == "2")
            {
                button1.BackColor = Color.Gainsboro;
                button2.BackColor = Color.Gainsboro;
                button3.BackColor = Color.Gainsboro;
                button4.BackColor = Color.Gainsboro;
                button5.BackColor = Color.Gainsboro;
                button1.ForeColor = Color.DeepSkyBlue;
                button2.ForeColor = Color.DeepSkyBlue;
                button3.ForeColor = Color.DeepSkyBlue;
                button4.ForeColor = Color.DeepSkyBlue;
                button5.ForeColor = Color.DeepSkyBlue;
                this.BackColor = Color.White;
            }
            // 如果 %appdata%\Duchie\ERSCT 資料夾中沒有 lang.txt，創建它
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Duchie\ERSCT\lang.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            // 如果 %appdata%\Duchie\ERSCT 資料夾中的 lang.txt 內容為空，那麼改為 tch
            string lang = File.ReadAllText(path);
            if (string.IsNullOrEmpty(lang))
            {
                File.WriteAllText(path, "tch");
                lang = "tch";
            }

            // 如果 %appdata%\Duchie\ERSCT 資料夾中的 lang.txt 內容為 tch，將 button1~5 的文字內容依序改為 "清除當前存檔" "轉換存檔" "查看操作說明" "打開存檔位置" "離開"
            // 如果內容為 en，將 button1~5 的文字內容依序改為 "Clean saves" "Change saves" "View Operation Instructions" "Open saves path" "Exit"
            if (lang == "tch")
            {
                button1.Text = "清除當前存檔";
                button2.Text = "轉換存檔";
                button3.Text = "查看操作說明";
                button4.Text = "打開存檔位置";
                button5.Text = "離開";
            }
            else if (lang == "en")
            {
                button1.Text = "Clean saves";
                button2.Text = "Change saves";
                button3.Text = "View Operation Instructions";
                button4.Text = "Open saves path";
                button5.Text = "Exit";
            }
        }
    }
}
