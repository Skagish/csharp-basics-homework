﻿using System;
using System.Collections.Generic;

namespace ListExercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            //TODO: Write a C# program to iterate through all elements in a list.

            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            for (int i = 0; i < colors.Count; i++) {
              Console.WriteLine(colors[i]);
            }
            Console.ReadLine();
        }
    }
}
