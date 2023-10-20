using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TaturinAM.Sprint3.Task0.V15.Lib
{
    public class DataService : ISprint3Task0V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double t = 0.7;
            double sum = 0;

            for (int k = 1; k <= 10; k++)
            {
                double term = Math.Pow(t, k + 2) / (k + 1) * Math.Sin(t);
                sum += term;
            }
            return Math.Round(sum, 3);
        }
    }
}


