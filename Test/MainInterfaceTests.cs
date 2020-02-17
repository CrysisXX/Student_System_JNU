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
    public class MainInterfaceTests
    {
        [TestMethod()]
        public void UpdateNotifications()
        {
            string path;
            MainInterface mainInterface = new MainInterface();
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

            path = "../../" + "Properties\\Get_Notifications\\dist\\";

            int count = 0;
            while(count < 500000000)
            {
                count += 5;
                count -= 4;
                count *= 3;
                count /= 3;
            }

            Assert.IsTrue(File.Exists(path + "Campus_Notification.txt"));
            Assert.IsTrue(File.Exists(path + "Lecture_Notification.txt"));
            Assert.IsTrue(File.Exists(path + "Student_Notification.txt"));
            Assert.IsTrue(File.Exists(path + "Teacher_Notification.txt"));
        }

        [TestMethod()]
        public void loadNotificationTest()
        {
            int count = 0;
            while (count < 500000000)
            {
                count += 5;
                count -= 4;
                count *= 3;
                count /= 3;
            }

            MainInterface mainInterface = new MainInterface();
            mainInterface.loadNotification("Campus_Notification.txt");
            Assert.IsTrue(mainInterface.label_title.Text.Equals("校区公告概要"));
        }
    }
}