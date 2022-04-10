using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class03.Exercise1.Models
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; } = new List<Dog>();
        
        public static void PrintAllDogs()
        {
            Console.WriteLine("Dogs in shelter:");
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine($"ID: {dog.Id}, Name: {dog.Name}, Color: {dog.Color}");
            }
        }
    }
}
