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

namespace WindowsFormsApp1
{
    public partial class WriteExcuse : Form
    {
        public WriteExcuse()
        {
            this.Location = new System.Drawing.Point(500, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
            GlobalData.StartTimeY = this.StartTimePicker.Value.Year.ToString();
            GlobalData.StartTimeD = this.StartTimePicker.Value.Day.ToString();
            GlobalData.StartTimeM = this.StartTimePicker.Value.Month.ToString();
            GlobalData.EndTimeY = this.EndTimePicker.Value.Year.ToString();
            GlobalData.EndTimeM = this.EndTimePicker.Value.Month.ToString();
            GlobalData.EndTimeD = this.EndTimePicker.Value.Day.ToString();
        }



        private void previewButton_Click(object sender, EventArgs e)
        {
            GlobalData.ExcuseReason = this.ExcuseReason.Text;
            TimeSpan t = this.EndTimePicker.Value - this.StartTimePicker.Value;
            GlobalData.ExceseTotalDays = t.Days+"";
            LogHelper.WriteLog(typeof(WriteExcuse), "用户点击预览请假条");
            PreviewResult f = new PreviewResult();
            f.Show();
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            MainInterface f = new MainInterface();
            f.Show();
            this.Hide();
        }

        private void StartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            GlobalData.StartTimeY = this.StartTimePicker.Value.Year.ToString();
            GlobalData.StartTimeD = this.StartTimePicker.Value.Day.ToString();
            GlobalData.StartTimeM = this.StartTimePicker.Value.Month.ToString();
        }

        private void EndTimePicker_ValueChanged(object sender, EventArgs e)
        {
            GlobalData.EndTimeY = this.EndTimePicker.Value.Year.ToString();
            GlobalData.EndTimeM = this.EndTimePicker.Value.Month.ToString();
            GlobalData.EndTimeD = this.EndTimePicker.Value.Day.ToString();
        }

        private void ExcuseReason_TextChanged(object sender, EventArgs e)
        {
            GlobalData.ExcuseReason = this.ExcuseReason.Text;
        }
    }
}
