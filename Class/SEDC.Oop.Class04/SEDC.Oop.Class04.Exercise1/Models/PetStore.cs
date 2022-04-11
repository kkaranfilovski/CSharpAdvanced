using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.Exercise1.Models
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets { get; set; }

        public PetStore()
        {
            Pets = new List<T>();
        }

        public void PrintPets()
        {
            foreach (T pet in Pets)
            {
                Console.WriteLine(pet.Name);
            }
        }

        public void AddPet(T pet)
        {
            Pets.Add(pet);
        }

        public void BuyPet(string name)
        {
            T petToBuy = Pets.FirstOrDefault(x => x.Name == name);
            if(petToBuy != null)
            {
                Pets.Remove(petToBuy);
                Console.WriteLine("You have bought the pet.");
            }
            else
            {
                Console.WriteLine("No pet by that name.");
            }
        }


    }
}
