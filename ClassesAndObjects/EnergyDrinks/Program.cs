using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        /*
         A soft drink company recently surveyed 12,467 of its customers and found that approximately 14 percent 
         of those surveyed purchase one or more energy drinks per week.
        Of those customers who purchase energy drinks, approximately 64 percent 
        of them prefer citrus flavored energy drinks.

            Write a program that displays the following:

        - The approximate number of customers in the survey who purchased one or more energy drinks per week
        - The approximate number of customers in the survey who prefer citrus flavored energy drinks
        - Customers can only be counted as Natural number.
        */
        private static void Main(string[] args)
        {
            int numberSurveyed = 12467;
            int preferCitrus = CalculatePreferCitrus(numberSurveyed);
            int energyDrinkers = CalculateEnergyDrinkers(numberSurveyed);

            
            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine("Approximately " + energyDrinkers + " bought at least one energy drink");
            Console.WriteLine(preferCitrus + " of those " + "prefer citrus flavored energy drinks.");
            Console.ReadLine();
        }

        static int CalculateEnergyDrinkers(int numberSurveyed)
        {
            return Convert.ToInt16(Math.Floor(numberSurveyed * 0.14));
        }

        static int CalculatePreferCitrus(int numberSurveyed)
        {
            return Convert.ToInt16(Math.Floor(numberSurveyed * 0.64));
        }
    }
}
