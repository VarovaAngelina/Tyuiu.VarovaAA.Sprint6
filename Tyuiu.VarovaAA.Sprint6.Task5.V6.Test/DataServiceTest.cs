using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.VarovaAA.Sprint6.Task5.V6.Lib;
namespace Tyuiu.VarovaAA.Sprint6.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.VarovaAA.Sprint6\Tyuiu.VarovaAA.Sprint6.Task5.V6\bin\Debug\InPutFileTask5V6.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
