using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise3
{
    class Odometer
    {
        private int _mileage;
        private const int _maxMileage = 999999;
        private const int _minMileage = 0;
        public FuelGauge _FuelGauge;

        public Odometer(FuelGauge fuelGauge)
        {
            _FuelGauge = fuelGauge;
        }

        public int Report()
        {
            return _mileage;
        }

        public void IncrementMileage()
        {
            if (_mileage < _maxMileage)
            {
                _mileage++;
            }
            if (_mileage % 10 == 0)
            {
                _FuelGauge.DecreaseLevel();
            }
            else if (_mileage > _maxMileage)
            {
                _mileage = 0;
                _mileage++;
            }
        }
    }
}
