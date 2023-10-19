using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TaturinAM.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double p = 0;
            do
            {
                p += (Math.Pow(value, startValue) + (1.0 / 2.0)) * Math.Cos(startValue);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(p, 3);
        }
    }
}
