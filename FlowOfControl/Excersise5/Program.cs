using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //On your phone keypad, the alphabets are mapped to digits as follows: ABC(2), DEF(3), GHI(4), JKL(5), MNO(6), PQRS(7), TUV(8), WXYZ(9).
            //Write a program called PhoneKeyPad, which prompts user for a String (case insensitive), and converts to a sequence of keypad digits.
            Console.WriteLine("Write a word: ");
            string word = Console.ReadLine();
        }

        static string PhoneKeyPad(string word)
        {
            var letters = word.ToLower();
            var numCombo = "Your number is: ";
            string[] p2 = { "a", "b", "c" };
            string[] p3 = { "d", "e", "f" };
            string[] p4 = { "g", "h", "i" };
            string[] p5 = { "j", "k", "l" };
            string[] p6 = { "m", "n", "o" };
            string[] p7 = { "p", "q", "r", "s" };
            string[] p8 = { "t", "u", "v" };
            string[] p9 = { "w", "x", "y", "z" };

            for (int i = 0; i <= letters.Length; i++)
            {
                if (letters[i].ToString() == p2[0] || letters[i].ToString() == p2[1] || letters[i].ToString() == p2[2])
                {
                }
                if (letters[i].ToString() == p3[0] || letters[i].ToString() == p3[1] || letters[i].ToString() == p3[2])
                {
                }
                if (letters[i].ToString() == p4[0] || letters[i].ToString() == p4[1] || letters[i].ToString() == p4[2])
                {
                }
                if (letters[i].ToString() == p5[0] || letters[i].ToString() == p5[1] || letters[i].ToString() == p5[2])
                {
                }
                if (letters[i].ToString() == p6[0] || letters[i].ToString() == p6[1] || letters[i].ToString() == p6[2])
                {
                }
                if (letters[i].ToString() == p7[0] || letters[i].ToString() == p7[1] || letters[i].ToString() == p7[2] || letters[i].ToString() == p7[3])
                {
                }
                if (letters[i].ToString() == p8[0] || letters[i].ToString() == p8[1] || letters[i].ToString() == p8[2])
                {
                }
                if (letters[i].ToString() == p9[0] || letters[i].ToString() == p9[1] || letters[i].ToString() == p9[2] || letters[i].ToString() == p9[3])
                {
                }
                
            }

            return numCombo;

        }
    }
}
