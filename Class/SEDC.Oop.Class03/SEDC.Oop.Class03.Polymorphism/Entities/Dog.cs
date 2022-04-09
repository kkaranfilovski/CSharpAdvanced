using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class03.Polymorphism.Entities
{
    internal class Dog : Pet
    {
        public string Breed { get; set; }

        public Dog()
            :base("Sharko")
        {

        }

        public Dog(string name) 
            :base(name)
        {

        }

        public Dog(string name, string breed) 
            : base(name)
        {
            Breed = breed;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} the dog is eating.");
        }
    }
}
