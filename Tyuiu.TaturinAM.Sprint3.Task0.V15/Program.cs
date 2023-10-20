using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TaturinAM.Sprint3.Task0.V15.Lib;
namespace Tyuiu.TaturinAM.Sprint3.Task0.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Татурин А. М. | СМАРТб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Щепёткин И.А. | ИИПб-23-2                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда по  *");
            Console.WriteLine("* формуле, при t = 0,7                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            double t = 0.7;
            int startValue = 1;
            int endValue = 10;
            Console.WriteLine("Переменная T = " + t);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + endValue);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда " + ds.GetSumSeries(t, startValue, endValue));

            Console.ReadKey();
        }
    }
}
