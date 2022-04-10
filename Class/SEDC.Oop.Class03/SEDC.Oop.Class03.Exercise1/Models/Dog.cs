using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class03.Exercise1.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public static bool Validate(Dog dog)
        {
            if (dog.Color == null || dog.Name.Length < 2 || dog.Id < 0)
            {
                //Console.WriteLine("The dog doesnt have all the properties");
                return false;
            }
            else
            {
                //Console.WriteLine("Everything is ok");
                return true;
            }
        }
    }
}
