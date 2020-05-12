using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Cat:Animal,ICat
    {
        public override string ExplainMyself()
        {
            return "I am a cat.";
        }

        public void Meow()
        {
            Console.WriteLine("I am meowing...");
        }

    }
}
