using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            double firstInt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double secondInt = Convert.ToDouble(Console.ReadLine());
            var sum = firstInt + secondInt;
            var diff = firstInt - secondInt;
            if (sum == 15 || diff == 15 || firstInt == 15 || secondInt == 15)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();
        }
    }
}
