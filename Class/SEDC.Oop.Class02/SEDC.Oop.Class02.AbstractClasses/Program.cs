// See https://aka.ms/new-console-template for more information
using SEDC.Oop.Class02.Entities;

Console.WriteLine("Hello, World!");

//Person person = new Person();

var employee = new Employee(1, "Trajko", "Trajkov", 40);
var admin = new Admin(2, "admin1", "admin", "IT");

string info = employee.GetInfo();
Console.WriteLine(info);
Console.WriteLine(admin.GetInfo());

var krug = new Krug(5);
var kvadrat = new Kvadrat(4);

Console.WriteLine(krug.PresmetajPlostina());
Console.WriteLine(kvadrat.PresmetajPlostina());

