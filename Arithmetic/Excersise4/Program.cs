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
            Console.WriteLine("Enter a number to show factorial value: ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(Product1ToN(n));
            Console.ReadLine();
        }

        static int Product1ToN(int n)
        {
            int result = 1;
            while (n != 1)
            { result = result * n;
                    n = n - 1;
            }
            return result;
            
        }
    }
}
