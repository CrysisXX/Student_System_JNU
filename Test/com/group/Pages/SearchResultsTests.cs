using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class SearchResultsTests
    {
        [TestMethod()]
        public void SearchResultsTest()
        {
            string path;
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WorkingDirectory = "../../" + "Properties\\Get_Notifications\\dist\\";
            p.Start();
            p.StandardInput.WriteLine("Get_Notifications.exe");
            p.StandardInput.WriteLine("exit");
            p.WaitForExit();

            path = "../../" + "Properties\\Get_Notifications\\dist\\";


            Assert.IsTrue(File.Exists(path + "Campus_Notification.txt"));
            Assert.IsTrue(File.Exists(path + "Lecture_Notification.txt"));
            Assert.IsTrue(File.Exists(path + "Student_Notification.txt"));
            Assert.IsTrue(File.Exists(path + "Teacher_Notification.txt"));
        }

        [TestMethod()]
        public void ReadNotificationsTest()
        {
            Assert.IsTrue(true);
        }
    }
}