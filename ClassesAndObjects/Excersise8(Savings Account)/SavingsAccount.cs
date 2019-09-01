using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise8_Savings_Account_
{
    class SavingsAccount
    {
        private double _interestRate;
        private double _balance;

        public SavingsAccount(double interest, double balance)
        {
            _interestRate = interest;
            _balance = balance;
        }

        public void SubtractBalance(double value)
        {
            _balance -= value;
        }

        public void DepositBalance(double value)
        {
            _balance += value;
        }

        public void MonthlyInterestAdd()
        {
            _balance += _balance * (_interestRate / 100 /12);
        }

        public double ShowBalance()
        {
            return _balance;
        }

        public void SetInterest(double rate)
        {
            _interestRate = rate;
        }
        public void SetBalance(double rate)
        {
            _balance = rate;
        }
    }
}
