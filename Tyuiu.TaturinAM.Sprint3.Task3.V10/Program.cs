using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TaturinAM.Sprint3.Task3.V10.Lib;
namespace Tyuiu.TaturinAM.Sprint3.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Татурин А. М. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл foreach                                                      *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Татурин Артем Максимович | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить из строки все буквы p в строке:          *");
            Console.WriteLine("* gdfppf vfppt p                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value = "gdfppf vfppt p";
            char item = 'p';
            Console.WriteLine($" Строка = {value}.\n Буква = {item}.                                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.DeleteCharInString(value, item);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
