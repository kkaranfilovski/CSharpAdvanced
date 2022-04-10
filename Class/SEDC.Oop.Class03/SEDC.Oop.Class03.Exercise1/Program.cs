using SEDC.Oop.Class03.Exercise1.Models;

List<Dog> dogsForShelter = new List<Dog>
{
    new Dog(1, "aron", "white"),
    new Dog(-1, "Sparky", "red"),
    new Dog(0, "bob", "red")
};

foreach (Dog dog in dogsForShelter)
{
    if (Dog.Validate(dog))
    {
        DogShelter.Dogs.Add(dog);
    }
}

DogShelter.PrintAllDogs();



