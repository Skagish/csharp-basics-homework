 private static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
        }

How to sort this array?
1. myArray.Sort();
2. Sort(myArray);
3.✔ Array.Sort(myArray)  


static void Main(string[] args)
        {
            string[] wordList = { "good", "bad", "motorcycle", "dog", "people", "cat" };
            foreach (var item in wordList)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }

What will the console display?
1. "good", "bad", "motorcycle", "dog", "people", "cat" 
2.  good, bad, motorcycle, dog, people, cat
3.✔ goodbadmotorcycledogpeoplecat                              

static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = i;
            }
            int[] arr2 = new int[10];
            arr2[arr1.Length - 1] = -7;
            arr1.CopyTo(arr2, 0);
            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
            Console.ReadLine();
        }

What will console display?
1.✔  0 1 2 3 4 5 6 7 8 9
	 0 1 2 3 4 5 6 7 8 9         

2.  0 1 2 3 4 5 6 7 8 -7
	0 1 2 3 4 5 6 7 8 9

3.  0 1 2 3 4 5 6 7 8 9
	0 1 2 3 4 5 6 7 8 -7