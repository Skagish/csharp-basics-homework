﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            first();
            second();
            Console.ReadKey();
        }

        static void first()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;

            //fixme - should be 15 :|
            int sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }

        static void second()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            float d = 4.2f;
            float e = 5.3f;

            //fixme - should be 15.5 :| 
            float sum = a + b + c + d + e;
            Console.WriteLine(sum);

            Console.ReadLine();
        }
        
    }
}
