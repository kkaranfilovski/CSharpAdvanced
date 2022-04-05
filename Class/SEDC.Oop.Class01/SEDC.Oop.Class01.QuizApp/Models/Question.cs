using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Models
{
    public class Question
    {
        public string QuestionName { get; set; }
        public List<Answer> Answers { get; set; }
        public Question(string name, List<Answer> answers)
        {
            QuestionName = name;
            Answers = answers;
        }
    }
}
