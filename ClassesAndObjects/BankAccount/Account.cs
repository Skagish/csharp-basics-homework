using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        private string _name;
        private double _balance;
        private string _minusSign;

        public Account(string name, double balance)
        {
            _name = name;
            _balance = balance;
            _minusSign = "";
            if (balance < 0)
            {
                _minusSign = "-";
            }
        }

        public void ShowUserNameAndBalance()
        {
            Console.WriteLine($"{_name}, {_minusSign}${_balance.ToString("0.00").Replace("-", "")}");
        }
    }
}
