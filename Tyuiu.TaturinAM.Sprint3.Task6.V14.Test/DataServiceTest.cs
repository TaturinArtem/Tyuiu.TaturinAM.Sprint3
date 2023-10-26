using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint3.Task6.V14.Lib;
namespace Tyuiu.TaturinAM.Sprint3.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckParts()
        {
            DataService DataService = new DataService();
            int startValue = 7;
            int stopValue = 16;
            int sum = DataService.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(sum, 136);
        }
    }
}
