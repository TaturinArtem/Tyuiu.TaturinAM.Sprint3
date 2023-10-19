using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint3.Task2.V15.Lib;
namespace Tyuiu.TaturinAM.Sprint3.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;
            double p = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(0.298, p);
        }
    }
}
