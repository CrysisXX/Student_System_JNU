using Library;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
using TestLog4Net;
using WindowsFormsApp1.com.group.Entry;
using WindowsFormsApp1.com.group.Pages;

namespace WindowsFormsApp1
{
    public partial class ElectricityCharges : Form
    {
        public ElectricityCharges()
        {
            this.Location = new System.Drawing.Point(500, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
            //本地存在电费信息的文档 读取并展示
            if(File.Exists(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Search_Electricity\\dist\\" + "ElectInfo.txt"))
            {
                drawCurve(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Search_Electricity\\dist\\" + "ElectInfo.txt");
            }
            try
            {
                if (File.Exists(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Search_Electricity\\" + GlobalData.user.RoomId + "Info.xml"))
                {
                    XmlOperator<ElectInfo> xmlOperator = new XmlOperator<ElectInfo>();
                    ElectInfo info = xmlOperator.readXML(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Search_Electricity\\" + GlobalData.user.RoomId + "Info.xml");
                    this.label5.Text = info.Elect;
                    this.dateTimePicker1.Text = info.Time;
                }
                this.label4.Text = GlobalData.user.RoomId + "";
            }
            catch(Exception e)
            {
                LogHelper.WriteLog(typeof(ElectricityCharges),e);
                MessageBox.Show("请先完善信息");
            }
            
        }





        private void InitChart()
        {
            //定义图表区域
            this.chart1.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            this.chart1.ChartAreas.Add(chartArea1);
            //定义存储和显示点的容器
            this.chart1.Series.Clear();
            Series series1 = new Series("S1");
            series1.ChartArea = "C1";
            this.chart1.Series.Add(series1);
            //设置图表显示样式
            this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            this.chart1.ChartAreas[0].AxisY.Maximum = 100;
            this.chart1.ChartAreas[0].AxisX.Interval = 5;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            //设置标题
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("S01");
            this.chart1.Titles[0].Text = "XXX显示";
            this.chart1.Titles[0].ForeColor = Color.RoyalBlue;
            this.chart1.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            //设置图表显示样式
            this.chart1.Series[0].Color = Color.Red;
            
            
            this.chart1.Series[0].Points.Clear();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageDetail f = new MessageDetail();
            f.Show();
            this.Hide();
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
            CourseSelectionMainPage f = new CourseSelectionMainPage();
            f.Show();
            this.Hide();
        }

        private void MenuExaminationResults_Click(object sender, EventArgs e)
        {
            ExaminationResults f = new ExaminationResults();
            f.Show();
            this.Hide();
        }

        private void MenuElectricityCharges_Click(object sender, EventArgs e)
        {
            this.Refresh();
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void drawCurve(string path)
        {
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            // 统计文本行数
            StreamReader sr = new StreamReader(path, Encoding.GetEncoding("utf-8"));
            int linesNum = sr.ReadToEnd().Split('\n').Length;
            sr.Close();
            List<string> dates = new List<string>();
            List<float> degrees = new List<float>();
            for (int i = 0; i < linesNum - 2; i += 3)
            {
                dates.Add(allLines[i]);
            }
            for (int i = 1; i < linesNum; i += 3)
            {
                degrees.Add(float.Parse(allLines[i].Substring(0, allLines[i].Length - 1)));
            }
            dates.Reverse();
            degrees.Reverse();
            this.chart1.Series[0]["PieLineColor"] = "Black";
            this.chart1.Series[0].BorderWidth = 3;
            this.chart1.ChartAreas[0].AxisY.Maximum = (int)degrees.Max()+1;
            this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            this.chart1.Series[0].Points.DataBindXY(dates, degrees);
        }

        private void updateElectButton_Click(object sender, EventArgs e)
        {
            try {
                this.label4.Text = GlobalData.user.RoomId + "";
                if (GlobalData.user.RoomId.Equals(0))
                {
                    MessageBox.Show("更新失败，未完善宿舍号");
                    return;
                }
            }
            catch(Exception ex)
            {
                LogHelper.WriteLog(typeof(ElectricityCharges), ex);
                MessageBox.Show("更新失败，未完善宿舍号");
                return;
            }
            InvokeExe invokeExe = new InvokeExe();
            string filePath = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Search_Electricity\\dist\\getElect.exe";
            string workingDirectory = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Search_Electricity\\dist\\";
            string[] param = { GlobalData.user.RoomId+"" };
            string res = "";
            try
            {
                res = invokeExe.invoke(filePath, workingDirectory, param);
                this.label5.Text = res.Substring(16, 7);
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(ElectricityCharges), ex);
                MessageBox.Show("更新失败");
                return;
            }
            String time = DateTime.Now.ToString();
            this.dateTimePicker1.Text = time;
            ElectInfo info = new ElectInfo();
            info.Time = time;
            info.Elect = res.Substring(16, 7);
            XmlOperator<ElectInfo> xmlOperator = new XmlOperator<ElectInfo>();
            string infoPath = "";
            try
            {
                infoPath = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Search_Electricity\\" + GlobalData.user.RoomId + "Info.xml";
                xmlOperator.saveXML(infoPath,info);
             }
            catch(Exception ex)
            {
                LogHelper.WriteLog(typeof(ElectricityCharges), ex);
                MessageBox.Show("读取宿舍号失败");
            }
            string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Properties\\Search_Electricity\\dist\\" + "ElectInfo.txt";
            drawCurve(path);
            LogHelper.WriteLog(typeof(ElectricityCharges),"  "+info.ToString());
            MessageBox.Show("电费更新成功！");
        }
    }


}
