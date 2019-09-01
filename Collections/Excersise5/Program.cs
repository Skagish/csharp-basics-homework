using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter to check if number is happy!");
            int number = Convert.ToInt16(Console.ReadLine());

                if (CheckIfHappy(number) == true)
                {
                    Console.WriteLine("Number is happy!");
                
                }

                if (CheckIfHappy(number) == false)
                {
                    Console.WriteLine("Number is not happy!");
                   
                }
                
            
            

            Console.ReadLine();
        }

        static bool CheckIfHappy(int number)
        {
            /*
            ////////////////INTEGER TO INT LIST///////////////////////////
            var charArray = number.ToString().ToArray();
            var numArray = new List<int>();
            foreach (var num in charArray)
            {
                numArray.Add(Convert.ToInt16(num));
            }
            //////////////////////////////////////////////////////////////
            */
            
            int newSum = 0;
            var numbers = number;

            while (numbers != 1)
            {
                while (numbers != 0)
                {
                    int num = numbers % 10;
                    newSum += num * num;
                    numbers = numbers / 10;
                    if (numbers == 4)
                    {
                        return false;
                    }
                }
                numbers = newSum;
                newSum = 0;
            }

            /*
            for (int i = 0; i < length; i++)
            {
                newSum += numArray[i] * numArray[i];
            }
            */

            return true;
            
        }
    }
}
