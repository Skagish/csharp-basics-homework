using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise3
{
    class FuelGauge
    {
        private int _FuelGauge;
        private int _maxLevel = 70;
        private int _minLevel = 0;
        public int FuelLevel()
        {
            return _FuelGauge;
        }
        public void IncrementLevel()
        {
            if (_FuelGauge < _maxLevel)
            {
                _FuelGauge++;
            }
        }

        public void DecreaseLevel()
        {
            if (_FuelGauge > _minLevel)
            {
                _FuelGauge--;
            }
        }
    }
}
