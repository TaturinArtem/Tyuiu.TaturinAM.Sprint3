using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TaturinAM.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            startValue = 7;
            stopValue = 16;
            int sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int d = 1; d <= i; d++)
                {
                    if (i % d == 0)
                    {
                        if (d > 5)
                        {
                            sum += d;
                        }
                    }
                }
            }
            return sum;
        }
    }
}