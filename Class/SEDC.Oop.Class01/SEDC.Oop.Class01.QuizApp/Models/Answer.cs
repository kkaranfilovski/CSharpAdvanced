using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Models
{
    public class Answer
    {
        public string AnswerName { get; set; }
        public bool IsCorrectAnswer { get; set; }
        public int Id { get; set; }

        public Answer(int id, string answer, bool isCorrect)
        {
            AnswerName = answer;
            IsCorrectAnswer = isCorrect;
            Id = id;
        }
    }
}
