using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TaturinAM.Sprint3.Task2.V15.Lib;
namespace Tyuiu.TaturinAM.Sprint3.Task2.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Татурин А. М. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл do...while                                                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Татурин Артем Максимович | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму   *");
            Console.WriteLine("* ряда по формуле, при x = 0.5                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;
            Console.WriteLine($" Значение x = {value}.\n Стартовое значение цикла = {startValue}.\n Конечное значение цикла = {stopValue}.");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double p = ds.GetSumSeries(value, startValue, stopValue);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
