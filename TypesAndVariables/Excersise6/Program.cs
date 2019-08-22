using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your first single digit number: ");
            int digit1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write your second single digit number: ");
            int digit2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(digit1 + digit2);
            Console.ReadLine();

        }
    }
}
