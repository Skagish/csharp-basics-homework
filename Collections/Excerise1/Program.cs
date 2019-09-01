using System;
using System.Collections.Generic;


namespace CollectionExercise1
    {
        class Program
        {
            /**
               * Origination:
               * Audi -> Germany
               * BMW -> Germany
               * Honda -> Japan
               * Mercedes -> Germany
               * VolksWagen -> Germany
               * Tesla -> USA
               */

            private static void Main(string[] args)
            {
                string[] array = { "Audi->Germany", "BMW->Germany", "Honda->Japan", "Mercedes->Germany", "VolksWagen->Germany", "Mercedes->Germany", "Tesla->USA" };

                var list = new List<string>();
                var hash = new HashSet<string>();
                var dictionary = new Dictionary<string, string>();

                for (int i = 0; i < array.Length; i++)
                {
                    list.Add(array[i].Substring(0, array[i].IndexOf("->") - 1));
                    hash.Add(array[i].Substring(0, array[i].IndexOf("->") - 1));
                    if (!dictionary.ContainsKey(array[i].Substring(0, array[i].IndexOf("->"))))
                    {
                        dictionary.Add(
                            array[i].Substring(0, array[i].IndexOf("->")),
                            array[i].Substring(array[i].IndexOf("->") +2));
                    }

                }

                Console.WriteLine("List: ");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("HashSet: ");
                foreach (var item in hash)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Dictionary: ");
                foreach (var item in dictionary)
                {
                    Console.WriteLine($"{item.Key}->{item.Value}");
                }

                Console.ReadLine();
                //todo - replace array with a HashSet and print out the results

                //todo - replace array with a Dictionary (use brand as key and origination as value) and print out the results
            }


        }
    }
