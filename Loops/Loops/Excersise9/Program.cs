using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value between 2 and 12");
            Int16 value = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"The Desired sum: {value}");
            Console.WriteLine(RollDicesCheck(value));
            Console.ReadLine();
        }

        static string RollDicesCheck(int value)
        {
            var text = "";
            var rolledSum = 0;
            Random rng = new Random();

            while (value != rolledSum)
            {
                int dice1 = rng.Next(1, 7);
                int dice2 = rng.Next(1, 7);
                rolledSum = dice1 + dice2;
                text = text + $"{dice1} and {dice2} = {rolledSum}"+ Environment.NewLine;
            }
            return text;
        }
    }
}
