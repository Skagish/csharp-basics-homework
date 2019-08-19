using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise8
{
    class Program
    {
        static void Main(string[] args)
        {
            var slash = "/";
            var revSlash = "\\";
            var star = "*";
            var result = "";
            var lineCount = 1;
            int count = Convert.ToInt16(Console.ReadLine());
            int total = 32 * count;
            for (int i = 0; i <= total; i++)
            {
                if (lineCount == 1)
                {
                    for (int n = 0; n <= 32; n++)
                        if (i <= 16)
                        {
                            Console.WriteLine(slash);
                        }

                    if (i > 16)
                    {
                        Console.WriteLine(revSlash);
                    }

                    if (i % 32 == 0)
                    {
                        lineCount++;
                        Console.WriteLine(Environment.NewLine);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
