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

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.Location = new System.Drawing.Point(500, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        public void MainForm_Load(object sender, EventArgs e)
        {
            InformationManage im = new InformationManage();//优先读取用户信息

            TabPage TabPageCity1 = new TabPage("主界面");
            TabPageCity1.Name = "主界面";
            this.tabControl1.TabPages.Add(TabPageCity1);
            MainInterface mi = new MainInterface();                           //MainInterface：From  
            mi.TopLevel = false;
            mi.Parent = TabPageCity1;
            mi.ControlBox = false;
            mi.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mi.Text = null;
            mi.Dock = System.Windows.Forms.DockStyle.Fill;
            mi.Show();
            this.tabControl1.SelectedTab = TabPageCity1;

            TabPage TabPageCity2 = new TabPage("信息管理");
            TabPageCity2.Name = "信息管理";
            this.tabControl1.TabPages.Add(TabPageCity2);                       //InformationManage：From  
            im.TopLevel = false;
            im.Parent = TabPageCity2;
            im.ControlBox = false;
            im.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            im.Text = null;
            im.Dock = System.Windows.Forms.DockStyle.Fill;
            im.Show();


            TabPage TabPageCity3 = new TabPage("选课");
            TabPageCity3.Name = "选课";
            this.tabControl1.TabPages.Add(TabPageCity3);
            CourseSelectionMainPage csmp = new CourseSelectionMainPage();                           //CourseSelectionMainPage：From  
            csmp.TopLevel = false;
            csmp.Parent = TabPageCity3;
            csmp.ControlBox = false;
            csmp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            csmp.Text = null;
            csmp.Dock = System.Windows.Forms.DockStyle.Fill;
            csmp.Show();

            TabPage TabPageCity4 = new TabPage("查询成绩");
            TabPageCity4.Name = "查询成绩";
            this.tabControl1.TabPages.Add(TabPageCity4);
            ExaminationResults er = new ExaminationResults();                           //ExaminationResults：From  
            er.TopLevel = false;
            er.Parent = TabPageCity4;
            er.ControlBox = false;
            er.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            er.Text = null;
            er.Dock = System.Windows.Forms.DockStyle.Fill;
            er.Show();

            TabPage TabPageCity5 = new TabPage("查水电");
            TabPageCity5.Name = "查水电";
            this.tabControl1.TabPages.Add(TabPageCity5);
            ElectricityCharges ec = new ElectricityCharges();                           //ElectricityCharges：From  
            ec.TopLevel = false;
            ec.Parent = TabPageCity5;
            ec.ControlBox = false;
            ec.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ec.Text = null;
            ec.Dock = System.Windows.Forms.DockStyle.Fill;
            ec.Show();

            TabPage TabPageCity6 = new TabPage("填写请假条");
            TabPageCity6.Name = "填写请假条";
            this.tabControl1.TabPages.Add(TabPageCity6);
            WriteExcuse we = new WriteExcuse();                           //WriteExcuse：From  
            we.TopLevel = false;
            we.Parent = TabPageCity6;
            we.ControlBox = false;
            we.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            we.Text = null;
            we.Dock = System.Windows.Forms.DockStyle.Fill;
            we.Show();

            TabPage TabPageCity7 = new TabPage("校卡余额");
            TabPageCity7.Name = "校卡余额";
            this.tabControl1.TabPages.Add(TabPageCity7);
            SchoolCardBalance scb = new SchoolCardBalance();                           //SchoolCardBalance：From  
            scb.TopLevel = false;
            scb.Parent = TabPageCity7;
            scb.ControlBox = false;
            scb.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            scb.Text = null;
            scb.Dock = System.Windows.Forms.DockStyle.Fill;
            scb.Show();

            TabPage TabPageCity8 = new TabPage("查询就业信息");
            TabPageCity8.Name = "查询就业信息";
            this.tabControl1.TabPages.Add(TabPageCity8);
            SearchForEmploymentInformation sfei = new SearchForEmploymentInformation();                           //SearchForEmploymentInformation：From  
            sfei.TopLevel = false;
            sfei.Parent = TabPageCity8;
            sfei.ControlBox = false;
            sfei.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sfei.Text = null;
            sfei.Dock = System.Windows.Forms.DockStyle.Fill;
            sfei.Show();

            TabPage TabPageCity9 = new TabPage("学校论坛");
            TabPageCity9.Name = "学校论坛";
            this.tabControl1.TabPages.Add(TabPageCity9);
            SchoolForum sf = new SchoolForum();                           //SchoolForum：From  
            sf.TopLevel = false;
            sf.Parent = TabPageCity9;
            sf.ControlBox = false;
            sf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sf.Text = null;
            sf.Dock = System.Windows.Forms.DockStyle.Fill;
            sf.Show();

            TabPage TabPageCity10 = new TabPage("自定义通知");
            TabPageCity10.Name = "自定义通知";
            this.tabControl1.TabPages.Add(TabPageCity10);
            SettingForm biss = new SettingForm();                           //SchoolForum：From  
            biss.TopLevel = false;
            biss.Parent = TabPageCity10;
            biss.ControlBox = false;
            biss.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            biss.Text = null;
            biss.Dock = System.Windows.Forms.DockStyle.Fill;
            biss.Show();
        }

        public void MessageDetail_Load(object sender, EventArgs e)
        {

            TabPage TabPageCity10 = new TabPage("通知详情");
            TabPageCity10.Name = "通知详情";
            this.tabControl1.TabPages.Add(TabPageCity10);
            MessageDetail md = new MessageDetail();                           //MessageDetail：From  
            md.TopLevel = false;
            md.Parent = TabPageCity10;
            md.ControlBox = false;
            md.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            md.Text = null;
            md.Dock = System.Windows.Forms.DockStyle.Fill;
            md.Show();
        }

        public void InformationManagement_To_MainInterface(object sender, EventArgs e)
        {
            TabPage TabPageCity = new TabPage();
            TabPageCity = this.tabControl1.TabPages["主界面"];
            this.tabControl1.SelectedTab = TabPageCity;
        }
    }
}
