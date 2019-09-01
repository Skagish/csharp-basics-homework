using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise5_Dates_
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = new Date(29, 05, 2000);
            
            Console.WriteLine(today.DisplayDate());
            today.SetDay(31);
            today.SetMonth(08);
            today.SetYear(2019);
            Console.WriteLine(today.DisplayDate());
            Console.ReadLine();
        }
    }
}
