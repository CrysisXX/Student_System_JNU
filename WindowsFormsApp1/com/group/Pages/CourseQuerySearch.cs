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
    public partial class CourseQuerySearch : Form
    {
        public CourseQuerySearch()
        {
            this.Location = new System.Drawing.Point(500, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
            MessageBox.Show("不在选课时间内无法选课");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
