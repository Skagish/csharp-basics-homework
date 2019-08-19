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
            Console.WriteLine("Enter first word: ");
            var word1 = Console.ReadLine();
            Console.WriteLine("Enter second word: ");
            var word2 = Console.ReadLine();
            

            string result = "";
            var neededLength = 30 - (word1.Length + word2.Length);
            var diference = 30 - word2.Length;
            result = result + word1;

            for (int i = word1.Length; i <= diference; i++)
            {
                result = result + ".";
            }

            result = result + word2;

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
