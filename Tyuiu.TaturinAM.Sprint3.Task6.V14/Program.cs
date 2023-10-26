using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TaturinAM.Sprint3.Task6.V14.Lib;
namespace Tyuiu.TaturinAM.Sprint3.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 3. Выполнил: Татурин А. М. | СМАРТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #3                                                     ");
            Console.WriteLine("* Тема: Обработка целочисленной информации                      ");
            Console.WriteLine("* Задание #6                                                    ");
            Console.WriteLine("* Вариант #14                                                   ");
            Console.WriteLine("* Выполнил: Татурин Артем Максимович | СМАРТб-23-               ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("*Напишите программу, которая ищет среди целых чисел, принадлежащих " +
                "числовому отрезку [7, 16] сумму всех делителей больше 5");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*d > 5, N >= 7 && N <= 16");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            int sum = DataService.GetSumTheDivisors(7, 16);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
