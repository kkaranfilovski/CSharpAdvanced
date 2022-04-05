using SEDC.Oop.Class01.QuizApp.Data;
using SEDC.Oop.Class01.QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Service
{
    public class MainService
    {
        private UserRepository UserRepository = new UserRepository();
        private Helpers helpers = new Helpers();
        private StudentService studentService = new StudentService();
        private TeacherService teacherService = new TeacherService();

        public void Main()
        {
            StartOptions();
        }
        private void StartOptions()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the QuizApp");
                Console.WriteLine("Choose one of the numbers of the options bellow to navigate through the App");
                Console.WriteLine("1. Login as Student");
                Console.WriteLine("2. Login as Teacher");
                Console.WriteLine("3. Exit app");

                string selection = Console.ReadLine();
                
                if(selection == "1")
                {          
                    var student = LogInAsStudent();
                    studentService.StudentOptions(student);
                    continue;
                }
                else if(selection == "2")
                {
                    var teacher = LogInAsTeacher();
                    teacherService.TeacherMenu();
                    continue;
                }
                else if(selection == "3")
                {
                    Console.WriteLine("Thanks for using the app");
                    break;
                }
            }
        }
        private Student LogInAsStudent()
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome Student. Login using your username and password");

            while (true)
            {
                try
                {
                    string userName = helpers.GetUserName();
                    var student = UserRepository.GetStudentByUserName(userName);

                    if(student != null)
                    {
                        if (student.DidQuiz)
                        {
                            throw new Exception("You already did the quiz. You cant do the quiz again.");
                        }

                        string password = helpers.GetPassword();
                        if(student.Password == password)
                        {
                            student.LoginAttempts = 3;
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Welcome {student.FullName}");
                            Console.ResetColor();
                            return student;
                        }
                        else if(student.LoginAttempts == 1)
                        {
                            Console.WriteLine("You dont have anymore attempts to Login. Exiting the app..");
                            Thread.Sleep(1000);
                            Environment.Exit(0);
                        }
                        else
                        {
                            student.LoginAttempts--;
                            throw new Exception($"Invalid password. You have {student.LoginAttempts} login attempts left");
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid username. Try again");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private Teacher LogInAsTeacher()
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome Teacher. Login using your username and password");

            while (true)
            {
                try
                {
                    string userName = helpers.GetUserName();
                    var teacher = UserRepository.GetTeacherByUserName(userName);

                    if (teacher != null)
                    {
                        string password = helpers.GetPassword();
                        if (teacher.Password == password)
                        {
                            teacher.LoginAttempts = 3;
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Welcome {teacher.FullName}");
                            Console.ResetColor();
                            return teacher;
                        }
                        else if (teacher.LoginAttempts == 1)
                        {
                            Console.WriteLine("You dont have anymore attempts to Login. Exiting the app..");
                            Thread.Sleep(1000);
                            Environment.Exit(0);
                        }
                        else
                        {
                            teacher.LoginAttempts--;
                            throw new Exception($"Invalid password. You have {teacher.LoginAttempts} login attempts left");
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid username. Try again");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
