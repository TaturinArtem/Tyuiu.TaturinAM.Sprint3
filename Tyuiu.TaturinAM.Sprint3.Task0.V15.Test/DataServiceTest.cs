using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint3.Task0.V15.Lib;
namespace Tyuiu.TaturinAM.Sprint3.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.7;
            int startValue = 1;
            int stopValue = 10;
            double p = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(0.226, p);
        }
    }
}
