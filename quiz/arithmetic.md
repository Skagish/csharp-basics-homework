 static void Main(string[] args)
        {
            int x = 1;
            for (int i = 1; i <= 10; i++)
            {
                x *= i;
            }
            Console.WriteLine(x);
            Console.ReadLine();
        }


What dose this calculate?
1. Average of 10 integers.
2. Median value of 10 integers.
3.✔ Factorial value of 10.         


static void Main(string[] args)
        {
            var a = 3;
            int b = 3;
            int c = 2;

            double x = a + b / c;

            Console.WriteLine(x);
            Console.ReadLine();
        }


What does the console write?
1. 3
2. 3.5
3.✔ 4   
4. 4.5

static void Main(string[] args)
        {
            double m = 3;
            var a = 3;
            int b = 3;
            int c = 2;

            m =- (a - b) / (c - b);

            Console.WriteLine(m);
            Console.ReadLine();
        }

What does the console write?
1. 3
2.✔ 0   
3. NullReferenceException exception
4. -3