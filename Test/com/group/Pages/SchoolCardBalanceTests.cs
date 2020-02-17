using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using WindowsFormsApp1.com.group.Pages;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class SchoolCardBalanceTests
    {
        SchoolCardBalance cardBalance = new SchoolCardBalance();
        string Path = "../../../WindowsFormsApp1/Properties/Query_Balance/";
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
            string res = null;
            while (p.StandardOutput.Peek() > -1)
            {
                res += (p.StandardOutput.ReadLine());
            }
            Assert.IsFalse(res.Equals(""));
        }

        [TestMethod()]
        public void loadTXTTest()
        {
            string balance_ch = "";

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
                sr.Close();
            }
            Assert.IsTrue(balance_ch.EndsWith("元"));
        }
    }
}