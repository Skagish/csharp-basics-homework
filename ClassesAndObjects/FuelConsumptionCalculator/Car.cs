using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Car
    {
        private double _odometerReading;
        private double _startKilometers; // Starting odometer reading
        private double _endKilometers; // Ending odometer reading
        private double _liters; // Liters of gas used per 100km
        public Car(double odometerReading)
        {
            _startKilometers = 0;
            _endKilometers = odometerReading;
            _liters = 0;
        }

        public double ConsumptionPer100km()
        {
            return 100 / ((_endKilometers - _startKilometers) / _liters);
        }

        public bool GasHog()
        {
            if (ConsumptionPer100km() > 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EconomyCar()
        {
            if (ConsumptionPer100km() < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void FillUp(int odometerReading, double liters)
        {
            _liters += liters;
            _endKilometers = odometerReading;
        }
    }
}
