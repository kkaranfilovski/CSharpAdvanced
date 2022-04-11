using SEDC.Oop.Class04.Exercise1.Models;

Dog aron = new Dog("aron", "dog", 7, true, "meat");
Dog sparky = new Dog("sparky", "dog", 3, true, "meat");

Cat tom = new Cat("tom", "cat", 3, false, 5);
Cat tom2 = new Cat("tom2", "cat", 3, false, 5);

Fish goldy = new Fish("goldy", "fish", 1, "golden", 5);

PetStore<Dog> dogStore = new PetStore<Dog>();

dogStore.AddPet(aron);
dogStore.AddPet(sparky);

dogStore.BuyPet("aron");

PetStore<Cat> catStore = new PetStore<Cat>();
catStore.AddPet(tom);
catStore.AddPet(tom2);

catStore.BuyPet("asd");

dogStore.PrintPets();
catStore.PrintPets();