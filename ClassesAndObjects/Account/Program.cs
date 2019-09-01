using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var bartosAccount = new Account("Barto's account", 100.00);
            var bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00);

            var aAccount = new Account("A account", 1000.00);
            var bAccount = new Account("B account", 0.00);
            var cAccount = new Account("C account", 0.00);

            Console.WriteLine("Initial state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);

            Transfer(aAccount,bAccount, 50.0);
            Transfer(bAccount, cAccount, 25.0);




            Console.WriteLine("Final state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);



            Console.ReadLine();
        }
        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.withdrawal(howMuch);
            to.deposit(howMuch);
        }
    }
}
