using System;

namespace ConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //math
            Console.WriteLine(Math.Max(100,200)); // only two numbers with max and min
            Console.WriteLine(Math.Min(100,200));
            Console.WriteLine(Math.Sqrt(200));

            //strings
            Console.WriteLine("Strings");
            string name = "Marcello";

            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());


            //Boolean
            bool x = true;
            bool y = false;
            Console.WriteLine(x);
            Console.WriteLine(y);

            int x1 = 40;
            int x2 = 30;
            Console.WriteLine(x1 > x2);
            Console.WriteLine(x1 < x2);
            Console.WriteLine(x1 == x2);
            Console.WriteLine(x1 != x2);

            //if else
            if (x1 > x2)
            {
                Console.WriteLine("x1 is greater than x2");
            } else
            {
                Console.WriteLine("x1 is not greater than x2");
            }

            //else if

            int x3 = 11;
            if (x3 < 10)
            {
                Console.WriteLine("HI");
            } else if (x3 > 15)
            {
                Console.WriteLine("HI2"); 
            } else
            {
                Console.WriteLine("hi3");
            }

            int x4 = 100;
            string out1 = (x4 < 200) ? "Have a nice day" : "message";
            Console.WriteLine(out1);

            //switch statements

            int x5 = 2;
            switch(x5)
            {
                case 1:
                    Console.WriteLine("1");
                    break;

                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
            }

            //while loop
            int x6 = 0;
            while (x6 < 5)
            {
                Console.WriteLine(x6);
                x6++;
            }

            //do while
            int x7 = 0;
            do
            {
                Console.WriteLine(x7);
                x7++;

            } while (x7 < 5);

            //for loop
            Console.WriteLine("For Loops");
            for (int i = 0; i < 100; i=i+5)
            {
                Console.WriteLine(i);
            }

            //break and continute
            Console.WriteLine("Break and continue statements");

            for (int i = 0; i < 10; i++)
            {
                if (i == 8)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 8)
                {
                    continue;
                }
                Console.WriteLine(i);

            }

            //arrays
            Console.WriteLine("Arrays");

            string[] aName = {"Amalan", "Marcello", "Evan", "Caytlyn", "Pat"};

            Console.WriteLine(aName[3]);

            Class1 a = new Class1();
            Console.WriteLine(a.name);
            //Console.WriteLine(a.age);
            a.name = "cat1";
            Console.WriteLine(a.name);

        }
    }
}
