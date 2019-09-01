using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise6
{
    class Program
    {
        private const string Path = "../Excersise6/lear.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                Console.WriteLine(s);
            }

            //var lineCount = File.ReadLines("../Excersise6/lear.txt").Count();
            Console.WriteLine("The number of lines: " + File.ReadLines("../Excersise6/lear.txt").Count());
            Console.WriteLine($"The number of words: {WordCounter(File.ReadAllText("../Excersise6/lear.txt"))}");
            Console.WriteLine($"The number of chars: {CharCounter(File.ReadAllText("../Excersise6/lear.txt"))}");



            Console.ReadLine();
        }

        public static int WordCounter(string text)
        {
            int count = 0;
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsWhiteSpace(text[i - 1]) == true)
                {
                    if (char.IsLetterOrDigit(text[i]) == true ||
                        char.IsPunctuation(text[i]))
                    {
                        count++;
                    }
                }
            }

            if (text.Length > 2)
            {
                count++;
            }

            return count;
        }

        public static int CharCounter(string text)
        {
            int count = 0;
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsWhiteSpace(text[i]) == false)
                {
                    count++;
                }

                if (char.IsSeparator(text[i]) == true)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
