﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TaturinAM.Sprint3.Task7.V21.Lib
{
    public class DataService : ISprint3Task7V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int cnt = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((((2 * Math.Cos(x) + 2) / (2 * x - 1)) + Math.Cos(x) - 5 * x + 3), 2);
                valueArray[cnt] = y;
                cnt++;
            }
            return valueArray;
        }
    }
}
