using SEDC.Oop.Class03.Polymorphism.Entities;

List<Pet> pets = new List<Pet>()
{
    new Cat("meow", 2),
    new Dog("aron", "samoyed"),
    new Dog("sparky", "Doga"),
    new Dog(),
    new Dog("bark")
};

foreach (Pet pet in pets)
{
    pet.Eat();
}


