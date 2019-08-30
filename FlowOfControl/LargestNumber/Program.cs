using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(LargestNum(input1, input2, input3));
            Console.ReadLine();

            /*
            todo - expected output:
            Input the 1st number: 25
            Input the 2nd number: 78
            Input the 3rd number: 87
             */
        }

        static int LargestNum(int a, int b, int c)
        {
            int result = 0;
            if (a > b && a > c)
            {
                result = a;
            }

            else if (b > a && b > c)
            {
                result = b;
            }

            else if (c > a && c > b)
            {
                result = c;

            }

            return result;


        }
    }
}
