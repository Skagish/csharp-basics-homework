using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write distance in meters: ");
            double meters = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Write hours: ");
            int hours = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Write minutes: ");
            int min = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Write seconds: ");
            int sec = Convert.ToInt16(Console.ReadLine());

            
            double time = TimeInSeconds(hours, min, sec);
            Console.WriteLine(Mps(time, meters));
            Console.WriteLine(Kmph(time, meters));
            Console.WriteLine(Mph(time, meters));
            
            Console.ReadLine();

        }

        static double TimeInSeconds(int hours, int min, int sec)
        {
            int time = sec + min * 60 + hours * 3600;
            return time;
            
        }

        static string Mps(double timeInSeconds, double meters)
        {
            string speedText = "Your speed in meters/second is ";
            double speed = meters / timeInSeconds;
            return speedText + Convert.ToString(speed);
        }

        static string Kmph(double timeInSeconds, double meters)
        {
            string speedText = "\n\nYour speed in km/h is ";
            double speed = (meters / (timeInSeconds / 3600));
            return speedText + Convert.ToString(speed);
        }

        static string Mph(double timeInSeconds, double meters)
        {
            string speedText = "\n\nYour speed in miles/h is ";
            double speed = (meters * 0.000621371) / (timeInSeconds / 3600);
            return speedText + Convert.ToString(speed);
        }
    }
}
