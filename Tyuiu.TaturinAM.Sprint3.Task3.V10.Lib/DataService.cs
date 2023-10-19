using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TaturinAM.Sprint3.Task3.V10.Lib
{
    public class DataService : ISprint3Task3V10
    {
        public string DeleteCharInString(string value, char item)
        {

            foreach (char i in value)
            {
                if (i == item)
                {
                    value = value.Replace(item.ToString(), "");
                }
            }
            return value;
        }
    }
}
