using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var benben = new Account("Benson", -17.50);
            benben.ShowUserNameAndBalance();
            Console.ReadLine();
        }
    }
}
