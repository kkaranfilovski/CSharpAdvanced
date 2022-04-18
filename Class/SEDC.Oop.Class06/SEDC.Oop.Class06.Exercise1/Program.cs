using SEDC.Oop.Class06.Exercise1;
using static SEDC.Oop.Class06.Exercise1.Data;

Data data = new Data();

List<Person> people = data.GetAllPerson();
List<Dog> dogs = data.GetAllDogs();

Console.WriteLine("==============================TASK1==========================");

var task1 = people.Where(x => x.FirstName.StartsWith("R")).OrderByDescending(x=> x.Age).ToList();
task1.ForEach(x => Console.WriteLine(x));

Console.WriteLine("==============================TASK2==========================");

var task2 = dogs.Where(x => x.Color == "Brown" && x.Age > 3).OrderBy(x => x.Age).ToList();
task2.ForEach(x => Console.WriteLine(x));

Console.WriteLine("==============================TASK3==========================");

var task3 = people.Where(x => x.Dogs.Count > 2).OrderByDescending(x => x.FirstName).ToList();
task3.ForEach(x => Console.WriteLine(x));

Console.WriteLine("==============================TASK4==========================");
//Find and print all Freddy`s dogs names older than 1 year

var task4 = people.FirstOrDefault(x => x.FirstName == "Freddy").Dogs.Where(x => x.Age > 1).ToList();
task4.ForEach(x => Console.WriteLine(x));

Console.WriteLine("==============================TASK5==========================");
//Find and print Nathen`s first dog

var task5 = people.FirstOrDefault(x => x.FirstName == "Nathen").Dogs.FirstOrDefault();
Console.WriteLine(task5);

Console.WriteLine("==============================TASK6==========================");
//Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER

var task6 = people
    .Where(x => x.FirstName == "Cristofer" || x.FirstName == "Freddy" || x.FirstName == "Erin" || x.FirstName == "Amelia")
    .SelectMany(x => x.Dogs.Where(x => x.Color == "White")).OrderBy(x => x.Name).ToList();

task6.ForEach(x => Console.WriteLine(x));

