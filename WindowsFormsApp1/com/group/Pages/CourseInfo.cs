using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.com.group.Entry;
using WindowsFormsApp1.com.group.Pages;
using Microsoft.VisualBasic;
using System.IO;
using TestLog4Net;

namespace WindowsFormsApp1
{
    public partial class CourseInfo : Form
    {
        String stuId;
        String password;

        public CourseInfo()
        {
            this.Location = new System.Drawing.Point(500, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
            try
            {

                this.stuId = Convert.ToString(GlobalData.user.StudentId);
                this.password = GlobalData.user.Jwxtpassword;
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogHelper.WriteLog(typeof(CourseInfo), "用户点击更新按钮");
            Process p = new Process();
            p.StartInfo.FileName = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Get_CourseInfo\\getCourseInfo.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WorkingDirectory = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Get_CourseInfo\\";
            p.Start();
            p.StandardInput.WriteLine(this.stuId);
            p.StandardInput.WriteLine(this.password);
            string filename = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Get_CourseInfo\\vcode.png";
            String validatecode = "";
            try
            {
                ValidateWindow vw = new ValidateWindow(filename);
                
                if (vw.ShowDialog() == DialogResult.OK)
                {
                    validatecode = vw.vcode;
                }
                vw.Close();
            }
            catch(Exception ex)
            {
                LogHelper.WriteLog(typeof(CourseInfo), ex);
            }
            p.StandardInput.WriteLine(validatecode);
            File.Delete(p.StartInfo.WorkingDirectory + "vcode.png");
            string res = null;
            while (p.StandardOutput.Peek() > -1)
            {
                res += (p.StandardOutput.ReadLine());
            }
            p.WaitForExit();
            LogHelper.WriteLog(typeof(CourseInfo), "后台进程运行结束");
            fillChart();
        }

        public void fillChart()
        {
            
            string filepath = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Get_CourseInfo\\" + "courseInfo.txt";
            string[] allLines = File.ReadAllLines(filepath, Encoding.GetEncoding("utf-8"));
            if (allLines == null || allLines.Length == 0)
            {
                MessageBox.Show("更新失败，密码或验证码不正确");
                return;
            }
            this.dataGridView1.Rows.Clear();
            // 统计文本行数
            try
            {
                StreamReader sr = new StreamReader(filepath, Encoding.GetEncoding("utf-8"));
                int linesNum = sr.ReadToEnd().Split('\n').Length;
                sr.Close();
                for (int i = 0; i < linesNum - 1; i++)
                {
                    int index = this.dataGridView1.Rows.Add();
                    string[] items = allLines[i].Split('|');
                    for (int j = 0; j < 8; j++)
                    {
                        if (items[j].Equals("&nbsp;")) items[j] = "无";
                        this.dataGridView1.Rows[index].Cells[j].Value = items[j];
                    }
                }
            }
            catch(Exception ex)
            {
                LogHelper.WriteLog(typeof(CourseInfo), ex);
                return;
            }
            LogHelper.WriteLog(typeof(CourseInfo), "用户更新课程信息");
        }
    }
}
