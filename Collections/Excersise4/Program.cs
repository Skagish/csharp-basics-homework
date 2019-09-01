using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            while (true)
            {
                Console.WriteLine("Enter name to add to list:");
                var name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                else
                {
                    names.Add(name);
                }
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
