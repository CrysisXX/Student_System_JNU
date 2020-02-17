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
using WindowsFormsApp1.com.group.Tools;

namespace WindowsFormsApp1
{
    public partial class PreviewResult : Form
    {
        public PreviewResult()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void outButton_Click(object sender, EventArgs e)
        {
            Excuse excuse = new Excuse();
            try
            {
                excuse.exportDoc();
                LogHelper.WriteLog(typeof(PreviewResult), "用户导出请假条成功  "+GlobalData.getExcuseInfo());
            }
            catch(Exception ex)
            {
                LogHelper.WriteLog(typeof(PreviewResult), ex);
            }
            
            this.Hide();
        }
    }
}
