using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3CSharp
{
    class Question2
    {
        public void qTwo() 
        {

            Console.Write("Number of words to build: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter the name " + (i + 1) + ": ");
                words[i] = Console.ReadLine();
            }

            Console.Write("World builder result is ");
            for (int i = 0; i < words.Length - 1; i++)
            {
                Console.Write(words[i] + ", ");
            }
            
            Console.Write(words[words.Length - 1]);
            Console.WriteLine("\nDONE!!");
        }

    }
}
