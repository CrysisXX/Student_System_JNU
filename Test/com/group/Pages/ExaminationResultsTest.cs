using System;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.com.group.Pages
{
    [TestClass]
    public class ExaminationResultsTest
    {
        [TestMethod]
        public void ExaminationResultsTests()
        {
            Boolean isExist = false;
            string path = "../../../../" + "\\WindowsFormsApp1\\Properties\\TextFile.txt";
            //FileInfo fi = new FileInfo(@"C:\a.txt");
            if (File.Exists(path)) { }
            {
                //存在文件
                isExist = true;
   
            }
            Assert.IsTrue(isExist);
        }
    }
}
