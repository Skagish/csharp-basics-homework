using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int from = 0;
            int to = 100;
            
            

            Console.WriteLine(SumAverageRunningInt(from, to));
            Console.ReadLine();
        }

        static string SumAverageRunningInt(int from, int to)
        {
            // 1-100 skaitļu izveide
            var result = Enumerable.Range(from, to + 1).ToArray();

            
            //Sum funkcija
            int sum = 0;
            for (int i = 0; i < result.Length; i++)
            {
                sum += result[i];
            }

            double average = Convert.ToDouble(sum) / to;

            string text = "This is sum: " + Convert.ToString(sum) + "\nThis is average: " + Convert.ToString(average);
            return text;
        }
    }
}
