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
            for (int i = 1; i <= 110; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(" Coza ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" Loza ");
                }
                else if (i % 7 == 0)
                {
                    Console.Write(" Woza ");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("CozaLoza");
                }
                else
                {
                    Console.Write($" {i} ");
                }
                if (i % 11 == 0)
                {
                    Console.WriteLine($" {i} ");
                }
                
            }

            Console.ReadLine();
        }
    }
}
