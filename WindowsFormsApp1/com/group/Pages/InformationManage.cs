using System;
using Library;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.com.group.Pages;
using WindowsFormsApp1.Entry;
using System.IO;
using TestLog4Net;

namespace WindowsFormsApp1
{
    public partial class InformationManage : Form
    {
        private XmlOperator<User> xmlOperator = new XmlOperator<User>();
        public InformationManage()
        {
            this.Location = new System.Drawing.Point(500, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
            if (!File.Exists("User//User" + GlobalData.stuId + ".xml"))
            {
                MessageBox.Show("第一次登录请完善信息");
            }
            User user = null;
            try
            {
                user = xmlOperator.readXML("User//User" + GlobalData.stuId + ".xml");
                this.nameInput.AppendText(user.Name.Length != 0 ? user.Name : "");
                this.jwxtPasswordInput.AppendText(user.Jwxtpassword.Length != 0 ? user.Jwxtpassword : "");
                this.stuIDInput.AppendText(!user.StudentId.Equals(0) ? user.StudentId + "" : "");
                this.schoolInput.AppendText(user.School.Length != 0 ? user.School : "");
                this.cardIDInput.AppendText(!user.StudentId.Equals(0) ? user.CardId + "" : "");
                this.passwordInput.AppendText(user.Password.Length != 0 ? user.Password : "");
                this.majorInput.AppendText(user.Major.Length != 0 ? user.Major : "");
                this.roomInput.AppendText(!user.RoomId.Equals(0) ? user.RoomId + "" : "");

                GlobalData.user = user;

            }
            catch(Exception ex)
            {
                LogHelper.WriteLog(typeof(InformationManage), ex);
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modifyClick(object sender, EventArgs e)
        {
        User user = new User();
            try
            {
                if(this.stuIDInput.Text.Length != 10){
                    MessageBox.Show("请输入正确学号");
                    return;
                }
                Regex regex = new Regex("[1-9][1-7][0-9][0-9]");
                if (!regex.IsMatch(this.roomInput.Text))
                {
                    MessageBox.Show("请输入正确宿舍号");
                    return;
                }
                user.Name = this.nameInput.Text;
                user.Jwxtpassword = this.jwxtPasswordInput.Text;
                user.Major = this.majorInput.Text;
                user.School = this.schoolInput.Text;
                user.Password = this.passwordInput.Text;
                user.StudentId = int.Parse(this.stuIDInput.Text);
                user.RoomId = int.Parse(this.roomInput.Text);
                user.CardId = int.Parse(this.cardIDInput.Text);
        }
            catch (System.FormatException exception ){
                LogHelper.WriteLog(typeof(InformationManage), exception);
                MessageBox.Show("数字信息未完善");
                return;
            }
            checkDir check = new checkDir();
            check.check("User//");
            xmlOperator.saveXML("User//User"+GlobalData.stuId+".xml",user);
            GlobalData.user = user;
            LogHelper.WriteLog(typeof(InformationManage), "用户修改用户信息  "+user.ToString());
            MessageBox.Show("修改成功!");
        }
        private void cancleButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.InformationManagement_To_MainInterface(sender,e);
        }


    }
}
