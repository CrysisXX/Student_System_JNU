using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.com.group.Pages
{
    [TestClass]
    public class WriteExcuseTest
    {
        [TestMethod]
        public void WriteExcuseTests()
        {
            Boolean isExist = false;
            string path = "../../../../" + "WindowsFormsApp1\\ExceseRes\\请假申请表.docx";
            if (File.Exists(path))
            {
                isExist = true;
            }
            Assert.IsTrue(isExist);
        }
    }
}
