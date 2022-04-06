// See https://aka.ms/new-console-template for more information
using SEDC.Oop.Class02.Entities.Interface;

var user = new User(5);

Console.WriteLine(user.GetID());

var pen = new Pen();
var computer = new Computer();
var phone = new Phone();

pen.Write();
computer.Write();
phone.Write();

static void LogInUser(IWriteMessage noteWriter)
{
    Console.WriteLine("Enter username:");
    string userName = Console.ReadLine();

    Console.WriteLine("Enter password:");
    string password = Console.ReadLine();

    noteWriter.Write();
}

LogInUser(computer);
LogInUser(pen);
LogInUser(phone);