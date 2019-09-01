using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Excersise9_SwapPoints_
{
    class Points
    {
        private int _value1;
        private int _value2;
        public Points(int value1, int value2)
        {
            _value1 = value1;
            _value2 = value2;
        }

        public int ReturnValue1()
        {
            return _value1;
        }

        public int ReturnValue2()
        {
            return _value2;
        }

        public void SetValue1(int value)
        {
            _value1 = value;
        }
        public void SetValue2(int value)
        {
            _value2 = value;
        }
    }
}
