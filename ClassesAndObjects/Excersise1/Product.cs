using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise1
{
    class Product
    {
        private decimal _price;
        private int _amount;
        private string _name;

        public Product(string name, decimal price, int amount)
        {
            this._name = name;
            this._amount = amount;
            this._price = price;
        }

        public void changeAmount()
        {
            Console.WriteLine("Enter your desired amount of product: ");
            this._amount = Convert.ToInt16(Console.ReadLine());
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name} price: {_price} amount: {_amount} ");
        }
    }
}
