using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.com.group.Pages
{
    public partial class ValidateWindow : Form
    {
        public String vcode = "";

        public ValidateWindow()
        {
            InitializeComponent();
        }

        public ValidateWindow(string filename)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            while (!File.Exists(filename)) { }
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            System.Drawing.Image ms = System.Drawing.Image.FromStream(fs);
            fs.Close();
            Bitmap img = new Bitmap(ms);
            this.VcodePic.Image = img;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.vcode = this.VcodeInput.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
