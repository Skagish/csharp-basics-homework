using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise6
//Pārtaisi ar citu metodi vienkāršāk. WriteLine.
{
    class Program
    {
        static void Main(string[] args)
        {
            CozaLozaWoza();
            //Console.WriteLine(CozaLozaWoza());
            Console.ReadLine();
        }

        static void CozaLozaWoza()
        {
            var numbers = Enumerable.Range(1, 110 + 1).ToArray();
            //var text = numbers.ToString().Select(c => c.ToString()).ToArray();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 11 == 0)
                {
                    Console.Write($" {i} \n\n");
                }
                else if (i % 3 == 0)
                {
                    Console.Write(" Loza ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" Woza ");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(" CozaLoza ");
                }
                else
                {
                    Console.Write($" {i} ");
                }
            }
        }
    }
}
