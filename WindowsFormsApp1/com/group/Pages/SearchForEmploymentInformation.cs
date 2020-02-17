using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SearchForEmploymentInformation : Form
    {
        public SearchForEmploymentInformation()
        {
            this.Location = new System.Drawing.Point(500, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void SearchForEmploymentInformation_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
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
            this.Refresh();
        }

        private void MenuForum_Click(object sender, EventArgs e)
        {
            SchoolForum f = new SchoolForum();
            f.Show();
            this.Hide();
        }
    }
}
