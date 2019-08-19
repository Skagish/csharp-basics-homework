using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordList = {"good", "bad", "motorcycle", "dog", "people", "cat"};

            GuessingGame(wordList);


        }

        static void GuessingGame(string[] wordlist)
        {
            Random chooseWord = new Random();
            var list = new List<string>(wordlist);                      //List of words
            var guessingWord = wordlist[chooseWord.Next(list.Count)];   // List[GeneratedNumber]
            var unguessedWord = new char[guessingWord.Length];       //New array with length of guessing wordw
            var usedLetters = "";                                       //Used chars
            var misses = 0;                                             //Missed chars

            //Console.WriteLine($"Word: {unguessedWord}");
            //Console.WriteLine($"Misses: {misses}");
            //Console.WriteLine($"Guessed: {usedLetters}");

            
            while (unguessedWord != Convert.ToString(guessingWord).ToCharArray())
            {
                DisplayGame(unguessedWord, misses, usedLetters);
                Console.WriteLine("Guess with a letter!");
                var userGuess = Convert.ToChar(Console.ReadLine());
                for (int i = 0; i <= guessingWord.Length + 2;i++)
                {
                    if (userGuess == guessingWord[i])
                    {
                        unguessedWord[i] = guessingWord[i];
                        usedLetters = usedLetters + userGuess + ""; //Used chars after input
                        DisplayGame(unguessedWord, misses, usedLetters);
                        Console.WriteLine("You guessed a letter!");
                        break;
                    }

                    if (userGuess != guessingWord[i])
                    {
                        misses++;
                        usedLetters = usedLetters + userGuess + ""; //Used chars after input
                        DisplayGame(unguessedWord, misses, usedLetters);
                        Console.WriteLine("You missed!");
                    }
                    userGuess = Convert.ToChar(Console.ReadLine());
                }
            }
        }

        static void DisplayGame(char[] unguessedWord, int misses, string usedLetters)
        {
            var unguessedString = new string(unguessedWord);
            string display =
                "-=-=-=-=-=-=-=-=-=-=-=-=-=-=" + Environment.NewLine +
                $"Word: {String.Join(" ",unguessedWord)}" + Environment.NewLine +
                $"Misses: {misses}" + Environment.NewLine +
                $"Guessed: {usedLetters}" + Environment.NewLine +
                "-=-=-=-=-=-=-=-=-=-=-=-=-=-=";
            Console.WriteLine(display);
        }
    }
}
