using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Zed A. Shaw";
            int myAge = 35;
            int myHeight = 74;  // inches
            int myWeight = 180; // lbs
            string myEyes = "Blue";
            string myTeeth = "White";
            string myHair = "Brown";

            Console.WriteLine("Let's talk about " + myName + ".");
            Console.WriteLine("He's " + myHeight + " inches tall.");
            Console.WriteLine("He's " + myWeight + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + myEyes + " eyes and " + myHair + " hair.");
            Console.WriteLine("His teeth are usually " + myTeeth + " depending on the coffee.");

            Console.WriteLine("If I add " + myAge + ", " + myHeight + ", and " + myWeight
                               + " I get " + (myAge + myHeight + myWeight) + ".");

            Console.ReadKey();
        }
    }
}