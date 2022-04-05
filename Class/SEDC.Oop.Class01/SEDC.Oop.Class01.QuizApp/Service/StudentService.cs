using SEDC.Oop.Class01.QuizApp.Data;
using SEDC.Oop.Class01.QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Service
{
    public class StudentService
    {
        private UserRepository UserRepository = new UserRepository();
        private Helpers helpers = new Helpers();
        public void StudentOptions(Student student)
        {
            Console.WriteLine("You will get 5 questions with 4 possible answers. GOOD LUCK!");

            var Questions = UserRepository.GetAllQuestions();

            foreach (var question in Questions)
            {
                Thread.Sleep(1000);
                Console.WriteLine("");
                Console.WriteLine(question.QuestionName);
                foreach (var answer in question.Answers)
                {                   
                    Console.WriteLine($"{answer.Id}. {answer.AnswerName}");    
                }

                int chosenAnswer = helpers.GetAnswer();
                if(question.Answers[chosenAnswer - 1].IsCorrectAnswer)
                {
                    student.Grade++;
                }
            }

            Console.WriteLine("Thanks for your answers.. Results SOON!");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your Grade is {student.Grade}");
            Console.ResetColor();
            student.DidQuiz = true;
            Thread.Sleep(3000);
        }
    }

}
