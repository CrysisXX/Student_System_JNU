using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class SearchResults : Form
    {
        public SearchResults()
        {
            LogHelper.WriteLog(typeof(SearchResults), "搜索结果页面加载成功");
            this.Location = new System.Drawing.Point(500, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
            string searchInfo = GlobalData.SearchInfo;
            this.searchInput.Text = GlobalData.SearchInfo;
            //  MessageBox.Show(searchInfo);
            this.searchResultList.Columns.Add("索引", 50, HorizontalAlignment.Center);
            this.searchResultList.Columns.Add("序号", 50, HorizontalAlignment.Center);
            this.searchResultList.Columns.Add("通知标题", 630, HorizontalAlignment.Center);
            this.searchResultList.Columns.Add("日期", 100, HorizontalAlignment.Center);
            // this.searchResultList.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            ReadNotifications("Campus_notification.txt", searchInfo);
            ReadNotifications("Educational_Department_notification.txt", searchInfo);
            ReadNotifications("Humanity_news.txt", searchInfo);
            ReadNotifications("Humanity_notification.txt", searchInfo);
            ReadNotifications("Global_Business_news.txt", searchInfo);
            ReadNotifications("Global_Business_notification.txt", searchInfo);
            ReadNotifications("Package_Engineering_news.txt", searchInfo);
            ReadNotifications("Package_Engineering_notification.txt", searchInfo);
            ReadNotifications("Translation_news.txt", searchInfo);
            ReadNotifications("Translation_notification.txt", searchInfo);
            this.searchResultList.ShowGroups = true;
        }

        public void ReadNotifications(string fileName, string searchInfo)
        {
            LogHelper.WriteLog(typeof(SearchResults), "检索"+fileName+"里的通知");
            int i = 0;
            int resultsNum = 0;
            int[] results = new int[150];
            string notifications;
            string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Get_Notifications\\dist\\" + fileName;
            // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 统计文本行数
            StreamReader sr = new StreamReader(path, Encoding.GetEncoding("utf-8"));
            int linesNum = sr.ReadToEnd().Split('\n').Length;
            //关闭SteamReader
            sr.Close();

            // 检查每个通知标题是否包含搜索关键字
            while (i < linesNum - 1)
            {
                notifications = allLines[i];
                if (notifications.Contains(searchInfo))
                    results[resultsNum] = 1;
                else
                    results[resultsNum] = 0;

                i += 3;
                resultsNum++;
            }

            ListViewGroup listViewGroup = new ListViewGroup();  //创建分组
            string groupHeader = "";
            string groupName = "";
            string notificationIndex = "0";

            if (fileName == "Campus_notification.txt")
            {
                groupHeader = "校区公告";
                groupName = "Campus";
                notificationIndex = "1";
            }

            if (fileName == "Educational_Department_notification.txt")
            {
                groupHeader = "教务处通知";
                groupName = "Education_Department";
                notificationIndex = "2";
            }

            if (fileName == "Humanity_news.txt")
            {
                groupHeader = "人文学院新闻";
                groupName = "Humanity_news";
                notificationIndex = "3";
            }

            if (fileName == "Humanity_notification.txt")
            {
                groupHeader = "人文学院通知";
                groupName = "Humanity_notification";
                notificationIndex = "4";
            }

            if (fileName == "Global_Business_news.txt")
            {
                groupHeader = "国际商学院新闻";
                groupName = "Global_Business_news";
                notificationIndex = "5";
            }

            if (fileName == "Global_Business_notification.txt")
            {
                groupHeader = "国际商学院通知";
                groupName = "Global_Business_notification";
                notificationIndex = "6";
            }

            if (fileName == "Package_Engineering_news.txt")
            {
                groupHeader = "包装工程学院新闻";
                groupName = "Package_Engineering_news";
                notificationIndex = "7";
            }

            if (fileName == "Package_Engineering_notification.txt")
            {
                groupHeader = "包装工程学院通知";
                groupName = "Package_Engineering_notification";
                notificationIndex = "8";
            }

            if (fileName == "Translation_news.txt")
            {
                groupHeader = "翻译学院新闻";
                groupName = "Translation_news";
                notificationIndex = "9";
            }

            if (fileName == "Translation_notification.txt")
            {
                groupHeader = "翻译学院通知";
                groupName = "Translation_notification";
                notificationIndex = "10";
            }

            listViewGroup.Header = groupHeader;  //设置组的标题。

            listViewGroup.Name = groupName;   //设置组的名称。

            listViewGroup.HeaderAlignment = HorizontalAlignment.Left;   //设置组标题文本的对齐方式。（默认为Left）

            this.searchResultList.Groups.Add(listViewGroup);


            int index = 0;
            int count = 1;
            string countStr = "";
            int locationIndex = 1;
            try
            {
                for (i = 0; i < allLines.Length / 3; i++)
                {
                    if (results[i] == 1)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.ImageIndex = index;
                        listViewItem.Text = notificationIndex + "-" + locationIndex;
                        countStr = "No." + count;
                        listViewItem.SubItems.Add(countStr);
                        listViewItem.SubItems.Add(allLines[i * 3]);
                        listViewItem.SubItems.Add(allLines[i * 3 + 1]);
                        listViewGroup.Items.Add(listViewItem);
                        this.searchResultList.Items.Add(listViewItem);
                        count++;
                        index++;
                    }
                    locationIndex++;
                }
            }
            catch(System.FormatException exception)
            {
                LogHelper.WriteLog(typeof(SearchResults), fileName+"中检索无匹配项");
                LogHelper.WriteLog(typeof(SearchResults), exception);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            LogHelper.WriteLog(typeof(SearchResults), "用户在搜索结果界面进行搜索");
            string searchInfo = searchInput.Text;
            this.searchResultList.Items.Clear();
            ReadNotifications("Campus_notification.txt", searchInfo);
            ReadNotifications("Educational_Department_notification.txt", searchInfo);
            ReadNotifications("Humanity_news.txt", searchInfo);
            ReadNotifications("Humanity_notification.txt", searchInfo);
            ReadNotifications("Global_Business_news.txt", searchInfo);
            ReadNotifications("Global_Business_notification.txt", searchInfo);
            ReadNotifications("Package_Engineering_news.txt", searchInfo);
            ReadNotifications("Package_Engineering_notification.txt", searchInfo);
            ReadNotifications("Translation_news.txt", searchInfo);
            ReadNotifications("Translation_notification.txt", searchInfo);
        }

        private void searchResultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = searchResultList.SelectedIndices;

            string complexIndex = "";
            string notificationIndex = "";
            string locationIndex = "";
            // 打开网站的url
            string url;

            foreach (int index in indexes)
            {
                complexIndex = searchResultList.Items[index].Text;
            }

            if (complexIndex != "")
            {
                notificationIndex = complexIndex.Substring(0, complexIndex.IndexOf("-"));
                locationIndex = complexIndex.Substring(complexIndex.Length - 1, 1);

                string fileName = "";

                if (int.Parse(notificationIndex) == 1)
                {
                    fileName = "Campus_notification.txt";
                }

                if (int.Parse(notificationIndex) == 2)
                {
                    fileName = "Educational_Department_notification.txt";
                }

                if (int.Parse(notificationIndex) == 3)
                {
                    fileName = "Humanity_news.txt";
                }

                if (int.Parse(notificationIndex) == 4)
                {
                    fileName = "Humanity_notification.txt";
                }

                if (int.Parse(notificationIndex) == 5)
                {
                    fileName = "Global_Business_news.txt";
                }

                if (int.Parse(notificationIndex) == 6)
                {
                    fileName = "Global_Business_notification.txt";
                }

                if (int.Parse(notificationIndex) == 7)
                {
                    fileName = "Package_Engineering_news.txt";
                }

                if (int.Parse(notificationIndex) == 8)
                {
                    fileName = "Package_Engineering_notification.txt";
                }

                if (int.Parse(notificationIndex) == 9)
                {
                    fileName = "Translation_news.txt";
                }

                if (int.Parse(notificationIndex) == 10)
                {
                    fileName = "Translation_notification.txt";
                }


                int location = int.Parse(locationIndex);

                // 读取文件
                string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Get_Notifications\\dist\\" + fileName;
                // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
                string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));

                // 获取url并转化为Uri
                url = allLines[location * 3 - 1];
                Uri uri = new Uri(url);
                MessageDetail messageDetail = new MessageDetail();
                // 设置url
                messageDetail.webBrowser1.Url = uri;
                // 显示页面
                messageDetail.Show();
                LogHelper.WriteLog(typeof(SearchResults), "用户点击搜索结果，索引为"+fileName+"中的"+"第"+locationIndex+"条通知");
            }
        }
    }
}
