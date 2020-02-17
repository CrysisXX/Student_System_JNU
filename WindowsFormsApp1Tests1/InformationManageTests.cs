using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WindowsFormsApp1.Entry;
using WindowsFormsApp1.com.group.Database;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class InformationManageTests
    {
        [TestMethod()]
        public void XMLSerializedTest()
        {
            if (Directory.Exists("User//"))
            {
                DirectoryInfo di = new DirectoryInfo("User//");
                di.Delete(true);
            }
                
            User user = new User();
            user.Name = "卓裕轩";
            //user.StudentId = 2016052355;
            user.Jwxtpassword = "12345";
            user.Major = "软件工程";
            XmlOperator p = new XmlOperator();
            p.XMLSerialized(user);
            Assert.IsTrue(File.Exists("User//User.xml"));
        }

        [TestMethod()]
        public void readXMLTest()
        {
            if (Directory.Exists("User//"))
            {
                DirectoryInfo di = new DirectoryInfo("User//");
                di.Delete(true);
            }　             　　              
            User user = new User();
            user.Name = "卓裕轩";
            //user.StudentId = 2016052355;
            user.Jwxtpassword = "12345";
            user.Major = "软件工程";
            XmlOperator p = new XmlOperator();
            p.XMLSerialized(user);
            User resUser = p.readXML("");
            Assert.AreEqual(user.Name, resUser.Name);
            Assert.AreEqual(user.Jwxtpassword, resUser.Jwxtpassword);
            Assert.AreEqual(user.Major, resUser.Major);
        }
    }
}