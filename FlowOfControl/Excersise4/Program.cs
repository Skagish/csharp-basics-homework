using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Excersise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day number: ");
            int dayNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(PrintDayInWord(dayNumber));
            Console.ReadLine();
        }

        static string PrintDayInWord(int n)
        {
            string day = "";
                if (n <= 7)
                {
                    if (n == 1)
                    {
                        day = "Monday";
                    }
                    if (n == 2)
                    {
                        day = "Tuesday";
                    }
                    if (n == 3)
                    {
                        day = "Wednesday";
                    }
                    if (n == 4)
                    {
                        day = "Thursday";
                    }
                    if (n == 5)
                    {
                        day = "Friday";
                    }
                    if (n == 6)
                    {
                        day = "Saturday";
                    }
                    if (n == 7)
                    {
                        day = "Sunday";
                    }
            }
                else
                {
                    day = "Not a valid day";
            }

                return day;
        }
    }
}
