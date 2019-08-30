using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a some text: ");
            string text = Console.ReadLine();

            NumOfUpperCases(text);

        }

        static void NumOfUpperCases(string text)
        {
            string filtered = "";
            int charPosition = filtered.Length;
            var charArr = text.ToCharArray();
            Console.WriteLine(charArr);
            for (int ch = 0; ch <= charArr.Length;ch++)
            {
                char ch1 = charArr[ch];
                if (Char.IsUpper(ch1) == true)
                {
                    filtered = filtered.Insert(charPosition, Convert.ToString(ch1));
                }

            }
            Console.WriteLine(filtered);
        }

        

        
    }
}
