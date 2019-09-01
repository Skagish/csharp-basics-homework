using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise9_SwapPoints_
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Points(5, 2);
            var p2 = new Points(-3, 6);

            PointSwap(p1, p2);

            Console.WriteLine("(" + p1.ReturnValue1() + ", " + p1.ReturnValue2() + ")");
            Console.WriteLine("(" + p2.ReturnValue1() + ", " + p2.ReturnValue2() + ")");

            Console.ReadLine();
        }

        static void PointSwap(Points p1, Points p2)
        {
            var temp1 = p1.ReturnValue1();
            var temp11 = p1.ReturnValue2();
            var temp2 = p2.ReturnValue1();
            var temp22 = p2.ReturnValue2();
            p1.SetValue1(temp2);
            p1.SetValue2(temp22);
            p2.SetValue1(temp1);
            p2.SetValue2(temp11);

        }
    }
}
