using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
            Console.ReadLine();
        }
    }
}
