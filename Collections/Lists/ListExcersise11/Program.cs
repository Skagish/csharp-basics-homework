using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        private static void Main(string[] args)
        {
            //TODO: Create an List with string elements
            var list = new List<string>();
            //TODO: Add 10 values to list
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            list.Add("6");
            list.Add("7");
            list.Add("8");
            list.Add("9");
            list.Add("10");
            //TODO: Add new value at 5th position
            list[5] = "50";
            //TODO: Change value at last position (Calculate last position programmatically)
            list[list.Count -1] = "last";
            //TODO: Sort your list in alphabetical order
            list.Sort();
            //TODO: Check if your list contains "Foobar" element
            list.Contains("Foobar");
            //TODO: Print each element of list using loop
            list.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
