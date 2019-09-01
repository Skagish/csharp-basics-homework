using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Excersise1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product bannana = new Product("Logitech mouse", (decimal)70.00, 14);
            Product apple = new Product("iPhone 5s", (decimal)999.99, 3);
            Product orange = new Product("Epson EB-U05", (decimal)440.46, 1);

            bannana.PrintProduct();
            apple.PrintProduct();
            orange.PrintProduct();
            orange.changeAmount();
            orange.PrintProduct();

            Console.ReadLine();

        }
    }
}
