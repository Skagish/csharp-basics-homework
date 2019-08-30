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
            Random rng = new Random();
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            int guess =  Convert.ToInt16(Console.ReadLine());
            int number = rng.Next(1, 100);

            if (guess == number)
            {
                Console.WriteLine("You guessed it! What are the odds!");
            } else if (guess < number)
            {
                Console.WriteLine($"Too Low! It was {number}");
            } else if (guess > number)
            {
                Console.WriteLine($"Too high! It was {number}");
            }

            Console.ReadLine();
        }
    }
}
