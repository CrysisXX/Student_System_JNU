using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLog4Net;
using WindowsFormsApp1.com.group.Pages;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            this.Location = new System.Drawing.Point(500, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LogHelper.WriteLog(typeof(Login), "用户点击登陆按钮");
            GlobalData.stuId = comboBox1.Text;
            LogHelper.WriteLog(typeof(Login), "用户成功登入");
            MainForm h = new MainForm();
            h.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
