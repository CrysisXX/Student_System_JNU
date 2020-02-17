using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using WindowsFormsApp1.Entry;
using System.IO;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class InformationManageTests
    {
        [TestMethod()]
        public void InformationManageTest()
        {
            XmlOperator<User> xmlOperator = new XmlOperator<User>();
            User user = new User();
            user.Name = "张锦亮";
            user.StudentId = 2016052355;
            user.Jwxtpassword = "12345";
            user.Major = "软件工程";
            string filename = "User//User" + user.StudentId.ToString() + ".xml";
            checkDir check = new checkDir();
            check.check("User//");
            xmlOperator.saveXML(filename, user);
            Assert.IsTrue(File.Exists(filename));
            User resUser = xmlOperator.readXML(filename);
            Assert.AreEqual(user.Name, resUser.Name);
            Assert.AreEqual(user.Jwxtpassword, resUser.Jwxtpassword);
            Assert.AreEqual(user.Major, resUser.Major);
        }
    }
}