using SEDC.Oop.Class01.QuizApp.Data;
using SEDC.Oop.Class01.QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Service
{
    public class TeacherService
    {
        public void TeacherMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Students:");
            Console.WriteLine("");
            foreach (var student in DataBase.Students)
            {
                if (student.DidQuiz)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{student.FullName} have Grade: {student.Grade}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(student.FullName + " didnt take the test");
                    Console.ResetColor();
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Enter any key to logout");
            Console.ReadLine();
        }
    }
}
