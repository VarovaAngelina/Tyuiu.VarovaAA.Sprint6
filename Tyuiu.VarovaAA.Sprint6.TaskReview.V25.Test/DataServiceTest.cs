using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint6.TaskReview.V25.Lib;
namespace Tyuiu.VarovaAA.Sprint6.TaskReview.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int k = 0;
            int l = 2;
            int r = 0;

            int[,] matrix = { { 1, 3, 3 }, { 2, 3, 1 }, { 3, 3, 4 } };
            int res = ds.GetMatrix(matrix, r, k, l);
            int wait = 7;

            Assert.AreEqual(wait, res);
        }
    }
}
