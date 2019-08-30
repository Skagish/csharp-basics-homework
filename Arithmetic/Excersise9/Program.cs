using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Excersise9
{
    class Program
    {
        static void Main(string[] args)
        {
            double bmi;

            //```BMI = weight x 703 / height ^ 2```.
            Console.WriteLine("Enter your weight in kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());

            weight *= 2.2046226;
            height *= 39.3701;

            bmi = weight * 703 / (height * height);
            Console.WriteLine($"Your BMI is {bmi}!");
            if (bmi > 18.5 && bmi < 25)
            {
                Console.WriteLine("Your BMI is optimal!");
            }
            if (bmi < 18.5)
            {
                Console.WriteLine("Your are underweight!");
            }
            if (bmi > 25)
            {
                Console.WriteLine("Your are overweigth!");
            }

            Console.ReadLine();
        }
    }
}
