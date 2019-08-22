using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer and count the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Convert.ToInt64(Console.ReadLine());
            if (input < 9223372036854775807)
            {
                if (input.ToString().Length < 0)
                {
                    //todo - check if n is less than zero
                    if (input < 0)
                    {
                        input *= -1;
                    }
                }

                int digits = 1;
                if (input > 10000000000)
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                }
                else if (input < 10000000000)
                {

                    digits = input.ToString().Length;

                }
                else
                {
                    Console.WriteLine("The number is not a long");
                }

                Console.WriteLine("Number of digits in the number: " + digits);
                Console.ReadLine();


            }

        }
    }
}

