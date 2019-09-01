using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../FlightPlanner/flights.txt";

        private static void Main(string[] args)
        {
            List<string> fligthList = new List<string>();
            var readText = File.ReadAllLines(Path);
            for (int s = 0; s < readText.Length; s++)
            {
                fligthList.Add(readText[s].Replace(" -> ", " To "));
            }
            fligthList.ForEach(Console.WriteLine);
            Console.WriteLine("Choose your starting city!");
            string startingCity = Console.ReadLine();
            HashSet<string> Cities = new HashSet<string>();
            for (int i = 0; i < readText.Length; i++)
            {
                Cities.Add(readText[i].Substring(0, readText[i].IndexOf(" -> ")));
            }
            List<string> planedRoute = new List<string>();
            while (true)
            {
                if (Match(Cities, startingCity))
                {
                    planedRoute.Add(Convert.ToString($"From {startingCity}"));
                    string currentCity = startingCity;
                    List<string> allowedCities = new List<string>();
                    while (true)
                    {
                        if (Match(Cities, currentCity))
                        {
                            for (int i = 0; i < fligthList.Count; i++)
                            {
                                if (currentCity == readText[i].Substring(0, readText[i].IndexOf(" -> ")))
                                {
                                    allowedCities.Add(readText[i]);
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine(readText[i]);
                                    Console.WriteLine("----------------------");
                                }
                            }
                            Console.WriteLine(" If you have arrived press enter or Choose destination!");
                            string destination = Console.ReadLine();
                            for (int i = 0; i < allowedCities.Count; i++)
                            {
                                if (destination == allowedCities[i].Substring(allowedCities[i].IndexOf(" -> ") +4))
                                {
                                    planedRoute.Add(Convert.ToString($"To {destination}"));
                                    currentCity = destination;
                                    if (currentCity  == startingCity)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (currentCity == startingCity)
                            {
                                Console.WriteLine("Press enter to end trip or re-enter the different city to fly to!");
                                currentCity = Console.ReadLine();
                                if (currentCity == "")
                                {
                                    break;
                                }
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid city! Enter the name of the city again!");
                            currentCity = Console.ReadLine();
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid City. Write the name of starting city again!");
                    startingCity = Console.ReadLine();
                }
            }
            Console.WriteLine("==============================");
            planedRoute.ToList().ForEach(Console.WriteLine);
            Console.WriteLine("==============================");
            Console.ReadLine();
        }

        static private bool Match(HashSet<string> Cities, string match)
        {
            bool found = false;
            foreach (var n in Cities)
            {
                if (match == n)
                {
                    found = true;
                }
            }
            return found;
        }
    }
}