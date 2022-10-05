using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBasics
{
    class Human
    {
        //member variable
        public string firstName;
        public string lastName;

        //constroctor
        public Human(string myFirstName, string lastName)
        {
            firstName = myFirstName;
            this.lastName = lastName;
        }

        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }
    }
}
