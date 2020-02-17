using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using WindowsFormsApp1.com.group.Pages;

namespace WindowsFormsApp1
{
    public partial class ExaminationResults : Form
    {
        public ExaminationResults()
        {
            this.Location = new System.Drawing.Point(500, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
            try
            {
                this.textBox1.Text = GlobalData.stuId;
                this.textBox2.Text = GlobalData.user.Name;
                this.textBox3.Text = GlobalData.user.Major;
            }
            catch
            {

            }

            this.comboBox1.Text = "主修";
            this.comboBox2.Text = "历史成绩";
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
            this.Refresh();
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

        private void resetButton_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo =Directory.GetParent( Directory.GetParent(Environment.CurrentDirectory).FullName);

            FileStream stream = File.Open(directoryInfo+"/Properties/TextFile.txt",FileMode.Open);
            StreamReader reader=new StreamReader(stream);
            string str=null;
            while ((str = reader.ReadLine()) != null)
            {
                string []s = Regex.Split(str, "\\s+", RegexOptions.IgnoreCase);
                Console.WriteLine("strLen=" + s.Length);
                int index = this.dataGridView1.Rows.Add();
                for (int i = 0; i < 9; i++)
                {
                    Console.WriteLine("column="+index+",i=" + i);
                    this.dataGridView1.Rows[index].Cells[i].Value = s[i];
                }
            }
            reader.Close();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
