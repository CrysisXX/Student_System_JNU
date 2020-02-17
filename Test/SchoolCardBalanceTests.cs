using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using Library;
using System.Windows.Forms;
using WindowsFormsApp1.com.group.Pages;
using System.IO;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class SchoolCardBalanceTests
    {
        SchoolCardBalance cardBalance = new SchoolCardBalance();
        readonly string Path = "";
        [TestMethod()]
        public void SchoolCardBalanceTest()
        {

            
            string workingDirectory = Path;
            Process p = new Process();
            p.StartInfo.FileName = Path + "myBalance.exe";
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WorkingDirectory = workingDirectory;
            p.StartInfo.UseShellExecute = false;
            p.Start();

            p.StandardInput.WriteLine("2016050215");
            p.StandardInput.WriteLine("123310");
            string picname = Path + "pic.png";
            ValidateWindow vw = new ValidateWindow(picname);
            String validatecode = "";
            if (vw.ShowDialog() == DialogResult.OK)
            {
                validatecode = vw.vcode;
            }
            vw.Close();
            p.StandardInput.WriteLine(validatecode);
            p.WaitForExit();

            
           
        }

        [TestMethod()]
        public void loadTXTTest()
        {
            string balance_ch;

            if (File.Exists(Path + "balance.txt"))
            {
                StreamReader sr = new StreamReader(Path + "balance.txt", Encoding.Default);
                List<string[]> line = new List<string[]>();

                string balance = "";
                while ((balance = sr.ReadLine()) != null)
                {
                    string[] content = balance.Split(new string[] { ":" }, StringSplitOptions.None);
                    line.Add(content);
                }
                balance_ch = line[4][0].Substring(0, line[4][0].IndexOf("元") + 1);

                // = line[1][0];
                //cardBalance.textBox4.Text = line[2][0];
                //cardBalance.textBox5.Text = line[3][0];
                //cardBalance.label5.Text = balance_ch;
                sr.Close();
            }
            //Assert.AreEqual("姓名：" + , output);
            //Assert.AreEqual("学号：" + GlobalData.user.Name);
            //Assert.AreEqual("院系专业：" + GlobalData.user.School + " " + GlobalData.user.Major);
        }
    }
}