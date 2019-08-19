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
            Console.WriteLine("Enter the length as a number: ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(Result(n));
            Console.ReadLine();
        }

        static string Result( int n)
        {
            string text = " ";
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    text = text + "Fizz ";
                }
                else if (i % 5 == 0)
                {
                    text = text + "Buzz ";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    text = text + "FizzBuzz ";
                }
                else { text = text + Convert.ToString($"{i} "); }

                if (i % 20 == 0)
                {
                    text = text + Environment.NewLine;
                }
            }

            return text;
        }
    }
}
