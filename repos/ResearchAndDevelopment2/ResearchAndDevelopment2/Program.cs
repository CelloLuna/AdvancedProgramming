using System;

namespace ResearchAndDevelopment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question One");
            Console.WriteLine("------------");

            Console.Write("Enter Initial value: ");
            int user = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Range: ");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= r; i++)
            {
                Console.WriteLine(user);
                user++;
            }
            Console.WriteLine("-----End----");



            Console.WriteLine("Question Two");
            Console.WriteLine("------------");

            Console.Write("Enter Initial value: ");
            user = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of values required: ");
            r = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < r; i++)
            {
                user = user + 100;
                Console.WriteLine(user);
            }

            Console.WriteLine("-----End----");
        }
    }
}
