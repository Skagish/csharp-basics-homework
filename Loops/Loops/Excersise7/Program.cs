using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet! /r/n Press y To Roll the dice!");
            var response = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Piglet(response));
            Console.ReadLine();
        }

        static string Piglet(char response)
        {
            string text = "";
            var result = 0;
            var rolled = 0;
            Random rng = new Random();
            
            while (response.ToString() == "y")
            {
                while (response.ToString() == "y")
                {
                    int dice = rng.Next(1, 10);
                    rolled = dice;
                    if (rolled == 1)
                    {
                        result = 0;
                        Console.WriteLine($"Your Rolled: {rolled}. Your score is: {result}");
                        break;
                    }
                    else
                    {
                        result += rolled;
                        Console.WriteLine($"Your Rolled: {rolled}. Your score is: {result}");
                        break;
                    }
                    
                }

                if (result == 0)
                {
                    text = $"Your score is {result}";
                    break;

                }

                if (result == 10)
                {
                    text = $"You won the game early! You got 10 Points!";
                    break;
                }
                else
                {
                    Console.WriteLine("Roll Again? y/n");
                    response = Convert.ToChar(Console.ReadLine());
                    text = $"Your score is {result}";
                }
            }

           
            return text;
        }
    }
}
