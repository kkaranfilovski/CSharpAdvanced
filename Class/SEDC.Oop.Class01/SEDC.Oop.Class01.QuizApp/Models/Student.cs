using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Models
{
    public class Student : Person
    {
        public bool DidQuiz { get; set; }
        public int Grade { get; set; }
        public Student(string name, string userName, string password)
            :base(name, userName, password)
        {
            DidQuiz = false;
            Grade = 0;
        }
    }
}
