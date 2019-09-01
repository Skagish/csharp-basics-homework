using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Excersise8_Savings_Account_
{
    class Program
    {
        static void Main(string[] args)
        {
            var savingsAccount = new SavingsAccount(0, 0);
            Console.WriteLine("What was your annual interest?");
            savingsAccount.SetInterest(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("What was your starting balance?");
            savingsAccount.SetBalance(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("How many months have passed since accounts establishment?");
            int time = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(FutureBalanceCalc(savingsAccount, time));
            Console.ReadLine();
        }

        static string FutureBalanceCalc(SavingsAccount account, int time)
        {
            var depositCount = 0;
            var withdrawCount = 0;
            double interestEarned = 0;
            for (int i = 0; i < time; i++)
            {
                var answer = "";
                Console.WriteLine($"How much did you deposit during month {i +1}?");
                answer = Console.ReadLine();
                if (answer != "" && answer != "0")
                {
                    account.DepositBalance(Convert.ToDouble(answer));
                    depositCount++;
                }
                Console.WriteLine($"How much did you withdraw during month {i +1}?");
                answer = Console.ReadLine();
                if (answer != "" && answer != "0")
                {
                    account.SubtractBalance(Convert.ToDouble(answer));
                    withdrawCount++;
                }

                var temp = account.ShowBalance();
                account.MonthlyInterestAdd();
                interestEarned += account.ShowBalance() - temp;
            }

            string text = $"Your end balance is {Math.Round(account.ShowBalance(), 2)}." +
                          $"You deposited money {depositCount} times" +
                          $"You withdrew money {withdrawCount} times" +
                          $"Your total interest earned is {Math.Round(interestEarned, 2)}";

            return text;
        }
    }
}
