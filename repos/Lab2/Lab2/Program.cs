using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question One");
            Console.WriteLine("------------");
            Console.WriteLine("Miles to Kilometers");

            Console.Write("\n Choose Miles: ");
            double mileNum = Convert.ToInt32(Console.ReadLine());
            double mileCalculation = (mileNum * 1.60934);

            Console.WriteLine(mileNum + " miles is " + mileCalculation + " kilometers");


            Console.WriteLine("Question Two");
            Console.WriteLine("------------");
            Console.WriteLine("Hours to Seconds");

            Console.Write("\n Enter Hour(s): ");
            double hourNum = Convert.ToInt32(Console.ReadLine());
            double hourCalculation = (mileNum * 3600);

            Console.WriteLine(hourNum + " hour(s) is " + hourCalculation + " seconds");


            Console.WriteLine("Question Three");
            Console.WriteLine("------------");
            Console.WriteLine("Pounds to Ounces");

            Console.Write("\n Enter Pounds: ");
            int lbNum = Convert.ToInt32(Console.ReadLine());
            int lbCalculation = (lbNum * 16);

            Console.WriteLine(lbNum + " pounds(s) is " + lbCalculation + " ounces");


            Console.WriteLine("Question Four");
            Console.WriteLine("------------");
            Console.WriteLine("Megabytes to Kilobytes");

            Console.Write("\n Enter Megabytes: ");
            int mbNum = Convert.ToInt32(Console.ReadLine());
            int mbCalculation = (mbNum * 1000);

            Console.WriteLine(mbNum + " megabytes(s) is " + mbCalculation + " kilobytes");


            Console.WriteLine("Question Five");
            Console.WriteLine("------------");
            Console.WriteLine("Miles per hour to meter per second");

            Console.Write("\n Enter Miles per hour: ");
            double mph = Convert.ToInt32(Console.ReadLine());
            double mphCalculation = (mileNum * 0.44704);

            Console.WriteLine(mph + " Miles per hour is " + mphCalculation + " Meters per second");


            Console.WriteLine("Question Six");
            Console.WriteLine("------------");
            Console.WriteLine("Next and previous integer");

            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int less = input - 1;
            int greater = input + 1;

            Console.WriteLine("Previous Value = " + less);
            Console.WriteLine("Next Value = " + greater);



            Console.WriteLine("Question Seven");
            Console.WriteLine("------------");
            Console.WriteLine("Count the characters in your name");

            Console.Write("Enter your first name: ");
            String fName = Console.ReadLine();

            Console.Write("Enter your middle name: ");
            String mName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            String lName = Console.ReadLine();

            int fLength = fName.Length;
            int mLength = mName.Length;
            int lLength = lName.Length;

            Console.WriteLine("Your first name is " + fLength + " characters long");
            Console.WriteLine("Your middle name is " + mLength + " characters long");
            Console.WriteLine("Your last name is " + lLength + " characters long");
        }
    }
}
