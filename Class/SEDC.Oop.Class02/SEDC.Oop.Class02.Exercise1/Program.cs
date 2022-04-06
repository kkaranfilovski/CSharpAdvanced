// See https://aka.ms/new-console-template for more information

using SEDC.Oop.Class02.Exercise1.Models;

var teacherOne = new Teacher(1, "Ivan", "ivand", "ivan123", "C#Advanced");
var teacherTwo = new Teacher(2, "Vlatko", "vlatko1", "vlatko123", "C#basic");

var studentOne = new Student(1, "Kristijan", "kiko1", "kiko123", new List<int> { 10, 10, 10 });
var studentTwo = new Student(1, "Igor", "igor1", "igor123", new List<int> { 9, 7, 9 });

teacherOne.PrintUser();
teacherTwo.PrintUser();
studentOne.PrintUser();
studentTwo.PrintUser();