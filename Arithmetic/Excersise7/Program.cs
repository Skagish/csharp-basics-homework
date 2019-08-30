using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Excersise8
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 0;
            double basePay = 0;
            while (basePay < 8)
            {
                Console.WriteLine("Enter the pay for one hour: ");
                basePay = Convert.ToDouble(Console.ReadLine());
                if (basePay < 8)
                {
                    Console.WriteLine("Worker can not earn less than 8$ per hour.");
                }
                else
                {
                    break;
                }
            }
            
           


            int hours = 61;

            while (hours > 60)
            {
                Console.WriteLine("Enter the hours worked: ");
                hours = Convert.ToInt16(Console.ReadLine());
                if (hours > 60)
                {
                    Console.WriteLine("Worker can not work over 60h per week.");
                    hours = 61;
                }
                else
                {
                    break;
                }
            }

            if (hours > 40 && hours < 60)
            {
                salary = 40 * basePay + (hours - 40) * (basePay * 1.5);
            }
            else
            {
                salary = basePay * hours;
            }
            Console.WriteLine($"Worker earned {salary} per week.");
            Console.ReadLine();



        }
    }
}
