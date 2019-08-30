using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write(minToDays(minutes));

            Console.Write(minToYears(minutes));

            Console.ReadLine();
        }

        static string minToDays(double minutes)
        {
            string dayText = "/\n\nThese are days: ";
            int minInDay = 1440;
            double days = minutes / minInDay;
            return dayText + Convert.ToString(days);
        }

        static string minToYears(double minutes)
        {
            string yearText = "\n\nThese are years: ";
            int minInYear = 525600;
            double years = minutes / minInYear;
            return yearText + Convert.ToString(years);
        }
    }
}
