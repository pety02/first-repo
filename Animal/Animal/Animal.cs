using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    abstract class Animal:IAnimal
    {
        protected string name { set; get; }
        protected string favouriteFood { set; get; }

        public Animal()
        {

        }
        public Animal(string name, string food)
        {
            this.name = name;
            this.favouriteFood = food;
        }

        public abstract string ExplainMyself();

        public void Eat()
        {
            Console.WriteLine("I am eating...");
        }
    }
}
