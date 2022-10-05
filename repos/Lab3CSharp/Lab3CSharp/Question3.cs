using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3CSharp
{
    class Question3
    {
        public void qThree()
        {
            Console.Write("Number of names to process: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter the name " + (i + 1) + ": ");
                names[i] = Console.ReadLine();
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Elements at index " + i + ": " + names[i]);
            }
        }
        


    }
}
