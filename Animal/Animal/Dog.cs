using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Dog:Animal,IDog
    {
        public override string ExplainMyself()
        {
            return "I am a dog.";
        }

        public void Bark()
        {
            Console.WriteLine("I am barking...");
        }
    }
}
