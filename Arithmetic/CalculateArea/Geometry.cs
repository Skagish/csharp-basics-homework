using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double areaOfCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }

        public static double areaOfRectangle(double length, double width)
        {
            return length * width;
        }

        public static double areaOfTriangle(double ground, double height)
        {
            return ground * height / 2;
        }
    }
}
