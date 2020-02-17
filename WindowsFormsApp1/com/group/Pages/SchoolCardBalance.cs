using Library;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLog4Net;
using WindowsFormsApp1.com.group.Pages;

namespace WindowsFormsApp1
{
    public partial class SchoolCardBalance : Form
    {
        public SchoolCardBalance()
        {
            this.Location = new System.Drawing.Point(500, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
            try
            {

                //初始化用户信息
                this.textBox1.Text = "姓名：" + GlobalData.user.StudentId + "";
                this.textBox2.Text = "学号：" + GlobalData.user.Name + "";
                this.textBox3.Text = "院系专业：" + GlobalData.user.School + " " + GlobalData.user.Major;
            }
            catch
            {

            }
                    
        }

        private void updateBalance(string Path)
        {


            //初始化用户信息
            this.textBox1.Text = "姓名：" + GlobalData.user.StudentId + "";
            this.textBox2.Text = "学号：" + GlobalData.user.Name + "";
            this.textBox3.Text = "院系专业：" + GlobalData.user.School + " " + GlobalData.user.Major;
            LogHelper.WriteLog(typeof(CourseInfo), "用户点击更新按钮");
            
            string workingDirectory = Path;                      
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Path + "myBalance.exe";
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WorkingDirectory = workingDirectory;
                p.StartInfo.UseShellExecute = false;
                p.Start();

                p.StandardInput.WriteLine(GlobalData.user.StudentId + "");
                p.StandardInput.WriteLine(GlobalData.user.Password);
                //MessageBox.Show(GlobalData.user.StudentId + "" + GlobalData.user.Password);
                string picname = Path + "pic.png";
                ValidateWindow vw = new ValidateWindow(picname);
                String validatecode = "";
                if (vw.ShowDialog() == DialogResult.OK)
                {
                    validatecode = vw.vcode;
                }
                vw.Close();
                p.StandardInput.WriteLine(validatecode);        
                string res = null;
                while (p.StandardOutput.Peek() > -1)
                {
                    res += (p.StandardOutput.ReadLine());
                }
                p.WaitForExit();
                LogHelper.WriteLog(typeof(CourseInfo), "后台进程运行结束");
                loadFile(Path);
                File.Delete(Path + "pic.png");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("获取余额失败");
                LogHelper.WriteLog(typeof(CourseInfo), e);
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) +
                @"\Properties\Query_Balance\";
            updateBalance(Path);
        }
        
        private void loadFile(string Path)
        {
            try
            {
                if (File.Exists(Path + "balance.txt"))
                {
                    StreamReader sr = new StreamReader(Path + "balance.txt", Encoding.Default);
                    List<string[]> line = new List<string[]>();

                    string balance = "";
                    while ((balance = sr.ReadLine()) != null)
                    {
                        string[] content = balance.Split(new string[] { ":" }, StringSplitOptions.None);
                        line.Add(content);
                    }
                    string balance_ch = line[4][0].Substring(0, line[4][0].IndexOf("元") + 1);

                    this.textBox7.Text = line[1][0];
                    this.textBox4.Text = line[2][0];
                    this.textBox5.Text = line[3][0];
                    this.label5.Text = balance_ch;
                    sr.Close();
                }
                System.DateTime currentTime = new System.DateTime();
                currentTime = System.DateTime.Now;
                string time = currentTime.ToString("f");
                this.textBox6.Text = "上次更新时间:" + time;
            }
            catch(Exception e)
            {
                LogHelper.WriteLog(typeof(CourseInfo), e);
            }
            LogHelper.WriteLog(typeof(CourseInfo), "更新校卡信息");
        }

        public string simulation()
        {
            string Path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) +
                @"\Properties\Query_Balance\";
            return Path;
        }
    }
}
