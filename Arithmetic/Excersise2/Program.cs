using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter to check number: ");
            int number = Convert.ToInt16(Console.ReadLine());
            if (CheckOddEven(number) == true)
            {
                Console.WriteLine("The number is Even! Bye!");
            }
            if (CheckOddEven(number) == false)
            {
                Console.WriteLine("The number is Odd! Bye!");
            }

            Console.ReadLine();
        }

        static bool CheckOddEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
