using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            processInput();

            

            void processInput()
            {
                 int userInput = DisplayMenu();
                if(userInput == 1)
                {
                    Create();
                }
                if (userInput == 2)
                {
                    Read();
                }
                if (userInput == 3)
                {
                   Update();
                }
                if (userInput == 4)
                {
                    Delete();
                }
                if (userInput == 5)
                {
                    Exit();
                } else
                {
                    Console.WriteLine("Invalid Option");
                    DisplayMenu();
                }
            }

            int DisplayMenu()
            {
                Console.WriteLine("");
                Console.WriteLine();
                Console.WriteLine("1.Create ");
                Console.WriteLine("2.Read ");
                Console.WriteLine("3.Update ");
                Console.WriteLine("4.Delete ");
                Console.WriteLine("5.EXIT ");

                var input = Console.ReadLine();
                return Convert.ToInt32(input);
            }

            void Create()
            {
                Console.WriteLine("Create Page");
                Console.ReadKey();
                DisplayMenu();
            }

            void Read()
            {
                Console.WriteLine("Read Page");
                Console.ReadKey();
                DisplayMenu();
            }

            void Update()
            {
                Console.WriteLine("Update Page");
                Console.ReadKey();
                DisplayMenu();
            }
            void Delete()
            {
                Console.WriteLine("Delete Page");
                Console.ReadKey();
                DisplayMenu();
            }

            void Exit()
            {
                Console.WriteLine("Goodbye");
                System.Environment.Exit(0);
            }
        }
    }
}
