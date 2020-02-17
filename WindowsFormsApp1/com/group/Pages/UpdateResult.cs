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
    public partial class UpdateResult : Form
    {
        public UpdateResult()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("修改成功");
        }
    }
}
