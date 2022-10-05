using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3CSharp
{
    class Question1
    {
        public string[] array = { "Keyboard", "Monitor", "Printer", "Server"};

        
        public void qOne()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Element and index " + i + ": " + array[i] + " | " + array[i].Length);
            }
        }
        
    }
}
