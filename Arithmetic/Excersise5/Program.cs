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
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            int guess = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(Response(guess));
            Console.ReadLine();

        }

        static string Response(int guess)
        {
            var rng = new Random();
            int number = rng.Next(1, 100);
            string result = "";
            if (guess == number)
            {
                result = "You guessed it!";
            } else if (guess < number)
            {
                result = "Sorry, you are too low.  I was thinking of " + Convert.ToString(number);
            }
            else
            {
                result = "Sorry, you are too high.  I was thinking of " + Convert.ToString(number);
            }

            return result;
        }
    }
}
