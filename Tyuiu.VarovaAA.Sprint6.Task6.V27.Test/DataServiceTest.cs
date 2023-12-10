using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint6.Task6.V27.Lib;
using System.IO;
namespace Tyuiu.VarovaAA.Sprint6.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\User\Desktop\тиу\InPutFileTask6V27.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "UpGwjzkBH OHcr KgepHrKCHa ";
            Assert.AreEqual(wait, res);
        }
    }
}
