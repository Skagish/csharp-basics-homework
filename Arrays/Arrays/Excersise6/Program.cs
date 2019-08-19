using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            Random rng = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = rng.Next(1, 100);
            }
            int[] arr2 = new int[10];
            arr1.CopyTo(arr2, 0);
            arr1[arr1.Length - 1] = -7;
            Console.WriteLine(String.Join(" ",arr1));
            Console.WriteLine(String.Join(" ", arr2));
            Console.ReadLine();
        }
    }
}
