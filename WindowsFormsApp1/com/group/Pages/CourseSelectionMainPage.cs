using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.com.group.Pages;
using HtmlAgilityPack;
using TestLog4Net;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class CourseSelectionMainPage : Form
    {
        String stuId;
        String password;
        public CourseSelectionMainPage()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CourseSelectionMainPage_Load(object sender, EventArgs e)
        {

        }

        private void MenuMainInterface_Click(object sender, EventArgs e)
        {
            MainInterface f = new MainInterface();
            f.Show();
            this.Hide();
        }

        private void MenuInfoManage_Click(object sender, EventArgs e)
        {
            InformationManage f = new InformationManage();
            f.Show();
            this.Hide();
        }

        private void MenuCourseSelect_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void MenuExaminationResults_Click(object sender, EventArgs e)
        {
            ExaminationResults f = new ExaminationResults();
            f.Show();
            this.Hide();
        }

        private void MenuElectricityCharges_Click(object sender, EventArgs e)
        {
            ElectricityCharges f = new ElectricityCharges();
            f.Show();
            this.Hide();
        }

        private void MenuWriteExcuse_Click(object sender, EventArgs e)
        {
            WriteExcuse f = new WriteExcuse();
            f.Show();
            this.Hide();
        }

        private void MenuCardBalance_Click(object sender, EventArgs e)
        {
            SchoolCardBalance f = new SchoolCardBalance();
            f.Show();
            this.Hide();
        }

        private void MenuEmploymentInfo_Click(object sender, EventArgs e)
        {
            SearchForEmploymentInformation f = new SearchForEmploymentInformation();
            f.Show();
            this.Hide();
        }

        private void MenuForum_Click(object sender, EventArgs e)
        {
            SchoolForum f = new SchoolForum();
            f.Show();
            this.Hide();
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            CourseQuerySearch cqs = new CourseQuerySearch();
            cqs.Show();
        }

        private void courseChooseButton_Click(object sender, EventArgs e)
        {
            CourseInfo ci = new CourseInfo();
            ci.Show();
        }
        // <summary>
        /// 定义的实体类用于接收数据
        /// </summary>
         public class Data
         {
            public string id { get; set; }
            public string value { get; set; }

         }
         List<Data> datas = new List<Data>();//学分信息
         List<Data> Tsq = new List<Data>();//通识教育群
         List<Data> Jcq = new List<Data>();//基础教育群
         List<Data> Zyq = new List<Data>();//专业选修群
        public void getMainPager()
        {
            

            char[] ce = new char[5];
            ce[0] = (char)13;
            ce[1] = (char)13;
            ce[2] = (char)10;
            ce[3] = (char)9;
            ce[4] = (char)9;
            string ts = new string(ce);
            ce = new char[6];
            ce[0] = (char)13;
            ce[1] = (char)13;
            ce[2] = (char)10;
            ce[3] = (char)9;
            ce[4] = (char)9;
            ce[5] = (char)9;
            string tes = new string(ce);
            HtmlAgilityPack.HtmlDocument htmlDocument = null;
            htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.Load(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Get_CourseInfo\\" + "default_page.html", Encoding.GetEncoding("utf-8"));//
            

            //HtmlNodeCollection collection = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='pnlXfyq']/table/tbody").ChildNodes;//节点xpath
            datas.Add(new Data() { id = "txtZxf", value = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='txtZxf']").Attributes["value"].Value });
            datas.Add(new Data() { id = "txtBxxf", value = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='txtBxxf']").Attributes["value"].Value });
            datas.Add(new Data() { id = "txtPjjd", value = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='txtPjjd']").Attributes["value"].Value });
            datas.Add(new Data() { id = "txtYhZxf", value = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='txtYhZxf']").Attributes["value"].Value });
            datas.Add(new Data() { id = "txtYhBxxfW", value = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='txtYhBxxfW']").Attributes["value"].Value });
            datas.Add(new Data() { id = "txtYhPjjd", value = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='txtYhPjjd']").Attributes["value"].Value });
            datas.Add(new Data() { id = "txtYhZxfN", value = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='txtYhZxfN']").Attributes["value"].Value });
            datas.Add(new Data() { id = "txtYhBxxfN", value = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='txtYhBxxfN']").Attributes["value"].Value });
            datas.Add(new Data() { id = "txtYhPjjdN", value = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='txtYhPjjdN']").Attributes["value"].Value });
            datas.Add(new Data() { id = "txtTsqXf", value = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='txtTsqXf']").Attributes["value"].Value });
            datas.Add(new Data() { id = "txtJcqXf", value = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='txtJcqXf']").Attributes["value"].Value });
            datas.Add(new Data() { id = "txtZyqXf", value = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='txtZyqXf']").Attributes["value"].Value });

            HtmlNodeCollection collectionTsq = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='dgrdKq']").ChildNodes;
            HtmlNodeCollection collectionJcq = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='dgrdKq0']").ChildNodes;
            HtmlNodeCollection collectionZyq = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='dgrdKq1']").ChildNodes;

            foreach (HtmlNode node in collectionTsq)
            {
                HtmlNodeCollection test = node.ChildNodes;
                int i = 0;
                string[] lineData = new string[2];
                foreach (HtmlNode t in test)
                {

                    string line = t.InnerText.Replace(" ", "");
                    if (line == ts || line == tes)
                        continue;

                    if (line.Length != 0)
                        lineData[i] = line;
                    else
                        lineData[i] = "";
                    i++;

                }
                Tsq.Add(new Data() { id = lineData[0], value = lineData[1] });
            }

            foreach (HtmlNode node in collectionJcq)
            {
                HtmlNodeCollection test = node.ChildNodes;
                int i = 0;
                string[] lineData = new string[2];
                foreach (HtmlNode t in test)
                {

                    string line = t.InnerText.Replace(" ", "");
                    if (line == ts || line == tes)
                        continue;

                    if (line.Length != 0)
                        lineData[i] = line;
                    else
                        lineData[i] = "";
                    i++;

                }
                Jcq.Add(new Data() { id = lineData[0], value = lineData[1] });
            }

            foreach (HtmlNode node in collectionZyq)
            {
                HtmlNodeCollection test = node.ChildNodes;
                int i = 0;
                string[] lineData = new string[2];
                foreach (HtmlNode t in test)
                {

                    string line = t.InnerText.Replace(" ", "");
                    if (line == ts || line == tes)
                        continue;

                    if (line.Length != 0)
                        lineData[i] = line;
                    else
                        lineData[i] = "";
                    i++;

                }
                Zyq.Add(new Data() { id = lineData[0], value = lineData[1] });
            }

            //    ////去除\r\n以及空格，获取到相应td里面的数据
            //    string[] line = node.InnerText.Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //循环输出查看结果是否正确,结果索引[1]-[Count-1] i=1;i<Count
            //foreach (var v in Tsq)
            //{
            //    Console.WriteLine(string.Join(",", v.id, v.value));
            //}
            //Console.WriteLine(Tsq.Count);
            //foreach (var v in Jcq)
            //{
            //    Console.WriteLine(string.Join(",", v.id, v.value));
            //}
            //Console.WriteLine(Jcq.Count);
            //foreach (var v in Zyq)
            //{
            //    Console.WriteLine(string.Join(",", v.id, v.value));
            //}
            //Console.WriteLine(Zyq.Count);
        }

        public void setMainPager()
        {
            textBox1.Text = datas[0].value;
            textBox2.Text = datas[3].value;
            textBox3.Text = datas[6].value;
            textBox4.Text = datas[9].value;
            textBox5.Text = datas[1].value;
            textBox6.Text = datas[4].value;
            textBox7.Text = datas[7].value;
            textBox8.Text = datas[10].value;
            textBox9.Text = datas[2].value;
            textBox10.Text = datas[5].value;
            textBox11.Text = datas[8].value;
            textBox12.Text = datas[11].value;

            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();

            listView1.BeginUpdate();
            listView2.BeginUpdate();
            listView3.BeginUpdate();

            for (int i=1;i<Tsq.Count;i++)
            {
                ListViewItem lvi = new ListViewItem(new string[] { Tsq[i].id,Tsq[i].value});
                listView1.Items.Add(lvi);
            }
            for (int i = 1; i < Jcq.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(new string[] { Jcq[i].id, Jcq[i].value });
                listView2.Items.Add(lvi);
            }
            for (int i = 1; i < Zyq.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(new string[] { Zyq[i].id, Zyq[i].value });
                listView3.Items.Add(lvi);
            }
            listView1.EndUpdate();
            listView2.EndUpdate();
            listView3.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogHelper.WriteLog(typeof(CourseSelectionMainPage), "用户点击更新按钮");
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
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(CourseSelectionMainPage), ex);
            }
            p.StandardInput.WriteLine(validatecode);
            File.Delete(p.StartInfo.WorkingDirectory + "vcode.png");
            string res = null;
            while (p.StandardOutput.Peek() > -1)
            {
                res += (p.StandardOutput.ReadLine());
            }
            p.WaitForExit();
            LogHelper.WriteLog(typeof(CourseSelectionMainPage), "后台进程运行结束");
            try
            {
                getMainPager();
                setMainPager();
            }
            catch(Exception ex)
            {
                MessageBox.Show("更新失败,用户信息错误");
                LogHelper.WriteLog(typeof(CourseSelectionMainPage), ex);
            }
            
            
        }
    }
   

}

