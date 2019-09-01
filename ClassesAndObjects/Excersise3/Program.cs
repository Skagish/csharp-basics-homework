using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var fuleGauge = new FuelGauge();
            Console.WriteLine("New odometer");
            for (int i = 0; i <= 30; i++)
            {
                fuleGauge.IncrementLevel();
            }
            
            Console.WriteLine($"Fuel level: {fuleGauge.FuelLevel()}");

            var odometer = new Odometer(fuleGauge);
            Console.WriteLine("Running...");
            for (int i = 0; i < 100; i++)
            {
                odometer.IncrementMileage();
            }
            Console.WriteLine($"Your mileage is {odometer.Report()} and current fuel is {fuleGauge.FuelLevel()} liters");
            Console.ReadKey();
        }
    }
}
