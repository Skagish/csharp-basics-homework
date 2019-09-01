using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            double odometerReading = 0;
            double liters = 0;


            //Car car = new Car( ?, ?, ?);
            Car bmw = new Car(odometerReading);
            Car audi = new Car(odometerReading);

            
             Console.Write("Enter BMW driven kilometers: ");
             odometerReading = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter liters: ");
            liters = Convert.ToInt32(Console.ReadLine());
            bmw.FillUp((int)odometerReading, liters);

            Console.Write("Enter AUDI driven kilometers: ");
            odometerReading = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter liters: ");
            liters = Convert.ToInt32(Console.ReadLine());
            audi.FillUp((int)odometerReading, liters);


            Console.WriteLine("Liters consumed per 100km(BMW) are: " + bmw.ConsumptionPer100km());
            Console.WriteLine("Is it GasHog:" + bmw.GasHog());
            Console.WriteLine("Is it Economy car:" + bmw.EconomyCar());
            Console.WriteLine("Liters consumed per 100km(AUDI) are: " + audi.ConsumptionPer100km());
            Console.WriteLine("Is it GasHog:" + audi.GasHog());
            Console.WriteLine("Is it Economy car:" + bmw.EconomyCar());
            

            Console.ReadLine();
        }
    }
}
