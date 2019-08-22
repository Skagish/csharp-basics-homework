using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            var num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            var num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(Prob(num1, num2));
            Console.ReadLine();
        }

        static bool Prob(int a, int b)
        {
            bool result = false;
            if (a == 15 || b == 15 || a + b == 15 || a - b == 15)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }




    }

}
