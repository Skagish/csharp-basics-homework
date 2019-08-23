using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double average = 0;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
                average = sum / upperBound;
            }

            Console.WriteLine(sum);
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}

