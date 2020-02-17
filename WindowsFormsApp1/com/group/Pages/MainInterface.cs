using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Diagnostics;
using TestLog4Net;
using Library;
using WindowsFormsApp1.com.group.Pages;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class MainInterface : Form
    {
        // 页面数索引
        int externPageindex = 1;
        int externPagenum = 0;

        public MainInterface()
        {
            this.Location = new System.Drawing.Point(500, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            LogHelper.WriteLog(typeof(MainInterface), "主界面加载成功");
            // 默认智科院和电工院无法选中
            collegeChoose.SetItemCheckState(4, CheckState.Indeterminate);
            collegeChoose.SetItemCheckState(5, CheckState.Indeterminate);

            string[] currentCollegeNews = new string [1];
            string[] currentCollegeNo = new string[1];
            if (GlobalData.user != null && GlobalData.user.School != null){
                if (GlobalData.user.School.Equals("人文学院")) {
                    collegeChoose.SetItemChecked(0, true);
                }
                else if (GlobalData.user.School.Equals("国际商学院"))
                {
                    collegeChoose.SetItemChecked(1, true);
                }
                else if (GlobalData.user.School.Equals("翻译学院")) {
                    collegeChoose.SetItemChecked(2, true);
                }
                else if (GlobalData.user.School.Equals("包装工程学院")) {
                    collegeChoose.SetItemChecked(3, true);
                }
                else {
                    MessageBox.Show("所在学院无新闻通知网页，默认加载包装工程学院新闻及通知");
                    collegeChoose.SetItemChecked(3, true);
                }
            }
            int i = 0;
            // 主界面加载时，首先显示校区通知
            string path = "../../" + "Properties\\Get_Notifications\\dist\\" + "Campus_notification.txt";
            // MessageBox.Show(path);
            // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的困难
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 统计文本行数
            StreamReader sr = new StreamReader(path, Encoding.GetEncoding("utf-8"));
            int linesNum = sr.ReadToEnd().Split('\n').Length;
            //关闭SteamReader
            sr.Close();
            // 对于长度超出40的标题字符串进行截取//
            for (i = 0; i < linesNum - 1; i++)
            {
                if ((i % 3) == 0 && allLines[i].Length >= 40)
                {
                    allLines[i] = allLines[i].Substring(0, 40) + "···";
                }
            }
            // 标题的获取
            linkLabel_1.Text = allLines[0];
            linkLabel_2.Text = allLines[3];
            linkLabel_3.Text = allLines[6];
            linkLabel_4.Text = allLines[9];
            linkLabel_5.Text = allLines[12];
            linkLabel_6.Text = allLines[15];
            linkLabel_7.Text = allLines[18];
            linkLabel_8.Text = allLines[21];
            linkLabel_9.Text = allLines[24];
            linkLabel_10.Text = allLines[27];
            linkLabel_11.Text = allLines[30];
            linkLabel_12.Text = allLines[33];

            // 时间的获取
            label_1.Text = allLines[1];
            label_2.Text = allLines[4];
            label_3.Text = allLines[7];
            label_4.Text = allLines[10];
            label_5.Text = allLines[13];
            label_6.Text = allLines[16];
            label_7.Text = allLines[19];
            label_8.Text = allLines[22];
            label_9.Text = allLines[25];
            label_10.Text = allLines[28];
            label_11.Text = allLines[31];
            label_12.Text = allLines[34];

            // 设置标题
            label_title.Text = "校区公告概要";

        }

        public void loadNotification(string fileName, int pageindex)
        {
            int i = 0;
            string path = "../../" + "Properties\\Get_Notifications\\dist\\" + fileName;
            // 检查文件是否存在
            if (File.Exists(path))
            {
                // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
                string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
                // 统计文本行数
                StreamReader sr = new StreamReader(path, Encoding.GetEncoding("utf-8"));
                int linesNum = sr.ReadToEnd().Split('\n').Length;
                //关闭SteamReader
                sr.Close();
                // 对于长度超出40的标题字符串进行截取
                for (i = 0; i < linesNum - 1; i++)
                {
                    if ((i % 3) == 0 && allLines[i].Length >= 40)
                    {
                        allLines[i] = allLines[i].Substring(0, 40) + "···";
                    }
                }

                // 标题的获取
                linkLabel_1.Text = allLines[pageindex * 36 + 0];
                linkLabel_2.Text = allLines[pageindex * 36 + 3];
                linkLabel_3.Text = allLines[pageindex * 36 + 6];
                linkLabel_4.Text = allLines[pageindex * 36 + 9];
                linkLabel_5.Text = allLines[pageindex * 36 + 12];
                linkLabel_6.Text = allLines[pageindex * 36 + 15];
                linkLabel_7.Text = allLines[pageindex * 36 + 18];
                linkLabel_8.Text = allLines[pageindex * 36 + 21];
                linkLabel_9.Text = allLines[pageindex * 36 + 24];
                linkLabel_10.Text = allLines[pageindex * 36 + 27];
                linkLabel_11.Text = allLines[pageindex * 36 + 30];
                linkLabel_12.Text = allLines[pageindex * 36 + 33];

                // 设置通知时间
                label_1.Text = allLines[pageindex * 36 + 1];
                label_2.Text = allLines[pageindex * 36 + 4];
                label_3.Text = allLines[pageindex * 36 + 7];
                label_4.Text = allLines[pageindex * 36 + 10];
                label_5.Text = allLines[pageindex * 36 + 13];
                label_6.Text = allLines[pageindex * 36 + 16];
                label_7.Text = allLines[pageindex * 36 + 19];
                label_8.Text = allLines[pageindex * 36 + 22];
                label_9.Text = allLines[pageindex * 36 + 25];
                label_10.Text = allLines[pageindex * 36 + 28];
                label_11.Text = allLines[pageindex * 36 + 31];
                label_12.Text = allLines[pageindex * 36 + 34];

                // 设置标题
                string headstr = null;
                if (fileName == "Campus_notification.txt")
                {
                    headstr = "校区公告 ";
                    label_title.Text = "校区公告概要";
                }
                if (fileName == "Educational_Department_notification.txt")
                {
                    headstr = "教务处通知 ";
                    label_title.Text = "教务处通知概要";
                }
                if (fileName == "Target_news.txt")
                {
                    headstr = "学院新闻 ";
                    label_title.Text = "学院新闻概要";
                }
                if (fileName == "Target_notification.txt")
                {
                    headstr = "学院通知 ";
                    label_title.Text = "学院通知概要";
                }
            }
            else
            {
                MessageBox.Show("未勾选任何学院，请勾选后进行查看!");
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void 通知ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LogHelper.WriteLog(typeof(MainInterface), "用户点击登陆按钮");
            //string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "\\Properties\\Get_Notifications\\dist\\" + "Get_Notifications.exe"; //测试一个word文档
            //System.Diagnostics.Process.Start(path); //打开此文件
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WorkingDirectory = "../../" + "Properties\\Get_Notifications\\dist\\";
            p.Start();
            p.StandardInput.WriteLine("Get_Notification.exe");
            p.StandardInput.WriteLine("exit");

            LogHelper.WriteLog(typeof(MainInterface), "通知更新成功");
            MessageBox.Show("通知更新成功！");
            this.MainInterface_Load(sender, e);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void searchButton_Click(object sender, EventArgs e)
        {
            LogHelper.WriteLog(typeof(MainInterface), "用户在主界面进行搜索");
            GlobalData.SearchInfo = SearchInfo.Text;
            SearchResults f = new SearchResults();
            f.Show();
        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notifyButton_Click(object sender, EventArgs e)
        {
            LogHelper.WriteLog(typeof(MainInterface), "用户点击校区通知按钮");
            externPageindex = 1;
            externPagenum = 1;
            loadNotification("Campus_notification.txt", 0);
            LogHelper.WriteLog(typeof(MainInterface), "校区通知页面加载成功");
        }

        private void officeButton_Click(object sender, EventArgs e)
        {
            LogHelper.WriteLog(typeof(MainInterface), "用户点击教务处通知按钮");
            externPageindex = 1;
            externPagenum = 1;
            loadNotification("Educational_Department_notification.txt", 0);
            LogHelper.WriteLog(typeof(MainInterface), "教务处通知页面加载成功");
        }

        private void collegeNotifyButton_Click(object sender, EventArgs e)
        {
            LogHelper.WriteLog(typeof(MainInterface), "用户点击学院新闻按钮");
            // 在这里判断是现在勾选了哪些学院
            externPagenum = judgeCheckeditem();
            PageIndex.Text = "1";
            externPageindex = 1;
            loadNotification("Target_news.txt", 0);
            LogHelper.WriteLog(typeof(MainInterface), "学院新闻页面加载成功");
        }

        private void schooolNotifyButton_Click(object sender, EventArgs e)
        {
            LogHelper.WriteLog(typeof(MainInterface), "用户点击学院通知按钮");
            // 在这里判断是现在勾选了哪些学院
            externPagenum = judgeCheckeditem();
            PageIndex.Text = "1";
            externPageindex = 1;
            loadNotification("Target_notification.txt", 0);
            LogHelper.WriteLog(typeof(MainInterface), "学院通知页面加载成功");
        }

        public string judgeNotifications()
        {
            string fileName = label_title.Text;
            // 确定现在在哪个通知页面
            if (fileName == "校区公告概要")
            {
                fileName = "Campus_notification.txt";
            }
            else if (fileName == "教务处通知概要")
            {
                fileName = "Educational_Department_notification.txt";
            }
            else if (fileName == "学院新闻概要")
            {
                fileName = "Target_news.txt";
            }
            else if (fileName == "学院通知概要")
            {
                fileName = "Target_notification.txt";
            }
            else
            {
                MessageBox.Show("发生了意外事件！");
            }
            return fileName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = null;
            string path = null;
            // 通知标题对应的url
            string url;
            // 判断现在在哪个通知页面
            fileName = judgeNotifications();
            path = "../../" + "Properties\\Get_Notifications\\dist\\" + fileName;
            // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 获取url并转化为Uri
            url = allLines[(externPageindex - 1) * 36 + 2];
            Uri uri = new Uri(url);
            MessageDetail messageDetail = new MessageDetail();
            // 设置url
            messageDetail.webBrowser1.Url = uri;
            // 显示页面
            messageDetail.Show();
            LogHelper.WriteLog(typeof(MainInterface), "用户点击"+fileName+"中第1条通知");
        }

        private void linkLabel_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = null;
            string path = null;
            // 通知标题对应的url
            string url;
            // 判断现在在哪个通知页面
            fileName = judgeNotifications();
            path = "../../" + "Properties\\Get_Notifications\\dist\\" + fileName;
            // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 获取url并转化为Uri
            url = allLines[(externPageindex - 1) * 36 + 5];
            Uri uri = new Uri(url);
            MessageDetail messageDetail = new MessageDetail();
            // 设置url
            messageDetail.webBrowser1.Url = uri;
            // 显示页面
            messageDetail.Show();
            LogHelper.WriteLog(typeof(MainInterface), "用户点击" + fileName + "中第2条通知");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = null;
            string path = null;
            // 通知标题对应的url
            string url;
            // 判断现在在哪个通知页面
            fileName = judgeNotifications();
            path = "../../" + "Properties\\Get_Notifications\\dist\\" + fileName;
            // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 获取url并转化为Uri
            url = allLines[(externPageindex - 1) * 36 + 8];
            Uri uri = new Uri(url);
            MessageDetail messageDetail = new MessageDetail();
            // 设置url
            messageDetail.webBrowser1.Url = uri;
            // 显示页面
            messageDetail.Show();
            LogHelper.WriteLog(typeof(MainInterface), "用户点击" + fileName + "中第3条通知");
        }

        private void linkLabel_4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = null;
            string path = null;
            // 通知标题对应的url
            string url;
            // 判断现在在哪个通知页面
            fileName = judgeNotifications();
            path = "../../" + "Properties\\Get_Notifications\\dist\\" + fileName;
            // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 获取url并转化为Uri
            url = allLines[(externPageindex - 1) * 36 + 11];
            Uri uri = new Uri(url);
            MessageDetail messageDetail = new MessageDetail();
            // 设置url
            messageDetail.webBrowser1.Url = uri;
            // 显示页面
            messageDetail.Show();
            LogHelper.WriteLog(typeof(MainInterface), "用户点击" + fileName + "中第4条通知");
        }

        private void linkLabel_5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = null;
            string path = null;
            // 通知标题对应的url
            string url;
            // 判断现在在哪个通知页面
            fileName = judgeNotifications();
            path = "../../" + "Properties\\Get_Notifications\\dist\\" + fileName;
            // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 获取url并转化为Uri
            url = allLines[(externPageindex - 1) * 36 + 14];
            Uri uri = new Uri(url);
            MessageDetail messageDetail = new MessageDetail();
            // 设置url
            messageDetail.webBrowser1.Url = uri;
            // 显示页面
            messageDetail.Show();
            LogHelper.WriteLog(typeof(MainInterface), "用户点击" + fileName + "中第5条通知");
        }

        private void linkLabel_6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = null;
            string path = null;
            // 通知标题对应的url
            string url;
            // 判断现在在哪个通知页面
            fileName = judgeNotifications();
            path = "../../" + "Properties\\Get_Notifications\\dist\\" + fileName;
            // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 获取url并转化为Uri
            url = allLines[(externPageindex - 1) * 36 + 17];
            Uri uri = new Uri(url);
            MessageDetail messageDetail = new MessageDetail();
            // 设置url
            messageDetail.webBrowser1.Url = uri;
            // 显示页面
            messageDetail.Show();
            LogHelper.WriteLog(typeof(MainInterface), "用户点击" + fileName + "中第6条通知");
        }

        private void linkLabel_7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = null;
            string path = null;
            // 通知标题对应的url
            string url;
            // 判断现在在哪个通知页面
            fileName = judgeNotifications();
            path = "../../" + "Properties\\Get_Notifications\\dist\\" + fileName;
            // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 获取url并转化为Uri
            url = allLines[(externPageindex - 1) * 36 + 20];
            Uri uri = new Uri(url);
            MessageDetail messageDetail = new MessageDetail();
            // 设置url
            messageDetail.webBrowser1.Url = uri;
            // 显示页面
            messageDetail.Show();
            LogHelper.WriteLog(typeof(MainInterface), "用户点击" + fileName + "中第7条通知");
        }

        private void linkLabel_8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = null;
            string path = null;
            // 通知标题对应的url
            string url;
            // 判断现在在哪个通知页面
            fileName = judgeNotifications();
            path = "../../" + "Properties\\Get_Notifications\\dist\\" + fileName;
            // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 获取url并转化为Uri
            url = allLines[(externPageindex - 1) * 36 + 23];
            Uri uri = new Uri(url);
            MessageDetail messageDetail = new MessageDetail();
            // 设置url
            messageDetail.webBrowser1.Url = uri;
            // 显示页面
            messageDetail.Show();
            LogHelper.WriteLog(typeof(MainInterface), "用户点击" + fileName + "中第8条通知");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = null;
            string path = null;
            // 通知标题对应的url
            string url;
            // 判断现在在哪个通知页面
            fileName = judgeNotifications();
            path = "../../" + "Properties\\Get_Notifications\\dist\\" + fileName;
            // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 获取url并转化为Uri
            url = allLines[(externPageindex - 1) * 36 + 26];
            Uri uri = new Uri(url);
            MessageDetail messageDetail = new MessageDetail();
            // 设置url
            messageDetail.webBrowser1.Url = uri;
            // 显示页面
            messageDetail.Show();
            LogHelper.WriteLog(typeof(MainInterface), "用户点击" + fileName + "中第9条通知");
        }

        private void linkLabel_10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = null;
            string path = null;
            // 通知标题对应的url
            string url;
            // 判断现在在哪个通知页面
            fileName = judgeNotifications();
            path = "../../" + "Properties\\Get_Notifications\\dist\\" + fileName;
            // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 获取url并转化为Uri
            url = allLines[(externPageindex - 1) * 36 + 29];
            Uri uri = new Uri(url);
            MessageDetail messageDetail = new MessageDetail();
            // 设置url
            messageDetail.webBrowser1.Url = uri;
            // 显示页面
            messageDetail.Show();
            LogHelper.WriteLog(typeof(MainInterface), "用户点击" + fileName + "中第10条通知");
        }

        private void linkLabel_11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = null;
            string path = null;
            // 通知标题对应的url
            string url;
            // 判断现在在哪个通知页面
            fileName = judgeNotifications();
            path = "../../" + "Properties\\Get_Notifications\\dist\\" + fileName;
            // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 获取url并转化为Uri
            url = allLines[(externPageindex - 1) * 36 + 32];
            Uri uri = new Uri(url);
            MessageDetail messageDetail = new MessageDetail();
            // 设置url
            messageDetail.webBrowser1.Url = uri;
            // 显示页面
            messageDetail.Show();
            LogHelper.WriteLog(typeof(MainInterface), "用户点击" + fileName + "中第11条通知");
        }

        private void linkLabel_12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = null;
            string path = null;
            // 通知标题对应的url
            string url;
            // 判断现在在哪个通知页面
            fileName = judgeNotifications();
            path = "../../" + "Properties\\Get_Notifications\\dist\\" + fileName;
            // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 获取url并转化为Uri
            url = allLines[(externPageindex - 1) * 36 + 35];
            Uri uri = new Uri(url);
            MessageDetail messageDetail = new MessageDetail();
            // 设置url
            messageDetail.webBrowser1.Url = uri;
            // 显示页面
            messageDetail.Show();
            LogHelper.WriteLog(typeof(MainInterface), "用户点击" + fileName + "中第12条通知");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void collegeChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private int judgeCheckeditem()
        {
            int pagenum = 0;
            ArrayList choosedCollegeNews = new ArrayList();
            ArrayList choosedCollegeNoti = new ArrayList();
            if (collegeChoose.GetItemChecked(0))
            {
                choosedCollegeNews.Add("Humanity_news.txt");
                choosedCollegeNoti.Add("Humanity_notification.txt");
            }
            if (collegeChoose.GetItemChecked(1))
            {
                choosedCollegeNews.Add("Global_Business_news.txt");
                choosedCollegeNoti.Add("Global_Business_notification.txt");
            }
            if (collegeChoose.GetItemChecked(2))
            {
                choosedCollegeNews.Add("Translation_news.txt");
                choosedCollegeNoti.Add("Translation_notification.txt");
            }
            if (collegeChoose.GetItemChecked(3))
            {
                choosedCollegeNews.Add("Package_Engineering_news.txt");
                choosedCollegeNoti.Add("Package_Engineering_notification.txt");
            }
            string[] news_res = new string[choosedCollegeNews.Count];
            string[] noti_res = new string[choosedCollegeNoti.Count];
            for (int i = 0; i < choosedCollegeNews.Count; i++)
            {
                news_res[i] = choosedCollegeNews[i].ToString();
                pagenum++;
            }
            for (int i = 0; i < choosedCollegeNoti.Count; i++)
            {
                noti_res[i] = choosedCollegeNoti[i].ToString();
            }
            BuildTarget.BuildTargetNews(news_res);
            BuildTarget.BulidTargetNotification(noti_res);

            return pagenum;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (int.Parse(PageIndex.Text) < externPagenum)
            {
                externPageindex++;
                PageIndex.Text = externPageindex.ToString();
                String fileName = judgeNotifications();
                loadNotification(fileName, externPageindex - 1);
            }
            else
            {
            }
        }

        private void PageIndex_Click(object sender, EventArgs e)
        {

        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (int.Parse(PageIndex.Text) > 1)
            {
                externPageindex--;
                PageIndex.Text = externPageindex.ToString();
                String fileName = judgeNotifications();
                loadNotification(fileName, externPageindex - 1);
            }
            else { }
        }
    }
}
