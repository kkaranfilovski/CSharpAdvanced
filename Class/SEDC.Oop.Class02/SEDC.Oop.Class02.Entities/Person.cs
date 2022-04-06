using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Entities
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        abstract public string GetInfo();

        public Person(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }

        public void GetDescription()
        {
            Console.WriteLine("This is a person");
        }
    }
}
