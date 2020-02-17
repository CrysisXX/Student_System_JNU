using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class ElectricityChargesTests
    {
        [TestMethod()]
        public void updateElectButtonTest()
        {
            InvokeExe invokeExe = new InvokeExe();
            string filePath = "../../../WindowsFormsApp1/Properties/Search_Electricity/dist/getElect.exe";
            string workingDirectory = "../../../WindowsFormsApp1/Properties/Search_Electricity/dist/";
            string[] param = {"3307" };
            string res = "";
            res = invokeExe.invoke(filePath, workingDirectory, param);
            Assert.IsFalse(res.Equals(""));
        }
    }
}