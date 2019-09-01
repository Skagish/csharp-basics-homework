using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "../midtermscores.txt";

        private static void Main(string[] args)
        {
            int counter9 = 0;
            int counter19 = 0;
            int counter29 = 0;
            int counter39 = 0;
            int counter49 = 0;
            int counter59 = 0;
            int counter69 = 0;
            int counter79 = 0;
            int counter89 = 0;
            int counter99 = 0;
            int counter100 = 0;
            
            var readText = File.ReadAllLines(Path);
            List<int> scoreList = new List<int>();

            for (int s = 0; s < readText.Length; s++)
            {
                var  lol = readText[s].Split(' ');
                foreach (var num in lol)
                {
                    scoreList.Add(Convert.ToInt16(num));
                }
            }

            foreach (var score in scoreList)
            {
                if (score >= 0 && score <= 9)
                {
                    counter9++;
                }
                if (score >= 10 && score <= 19)
                {
                    counter19++;
                }
                if (score >= 20 && score <= 29)
                {
                    counter29++;
                }
                if (score >= 30 && score <= 39)
                {
                    counter39++;
                }
                if (score >= 40 && score <= 49)
                {
                    counter49++;
                }
                if (score >= 50 && score <= 59)
                {
                    counter59++;
                }
                if (score >= 60 && score <= 69)
                {
                    counter69++;
                }
                if (score >= 70 && score <= 79)
                {
                    counter79++;
                }
                if (score >= 80 && score <= 89)
                {
                    counter89++;
                }
                if (score >= 90 && score <= 99)
                {
                    counter99++;
                }
                if (score == 100)
                {
                    counter100++;
                }
            }

            List<int> counters = new List<int>();
            counters.Add(counter9);
            counters.Add(counter19);
            counters.Add(counter29);
            counters.Add(counter39);
            counters.Add(counter49);
            counters.Add(counter59);
            counters.Add(counter69);
            counters.Add(counter79);
            counters.Add(counter89);
            counters.Add(counter99);
            counters.Add(counter100);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine($"00-09: {Draw(counter9)}");
            Console.WriteLine($"10-19: {Draw(counter19)}");
            Console.WriteLine($"20-29: {Draw(counter29)}");
            Console.WriteLine($"30-39: {Draw(counter39)}");
            Console.WriteLine($"40-49: {Draw(counter49)}");
            Console.WriteLine($"50-59: {Draw(counter59)}");
            Console.WriteLine($"60-69: {Draw(counter69)}");
            Console.WriteLine($"70-79: {Draw(counter79)}");
            Console.WriteLine($"80-89: {Draw(counter89)}");
            Console.WriteLine($"90-99: {Draw(counter99)}");
            Console.WriteLine($"  100: {Draw(counter100)}");

            Console.WriteLine("--------------------------------------");
            Console.ReadLine();
        }

        public static string Draw(int counter)
        {
            string stars = "";

            for (int i = 0; i < counter; i++)
            {
                stars += "*";
            }


            return stars;
        }
    }
}
