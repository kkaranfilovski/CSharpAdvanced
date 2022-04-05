using SEDC.Oop.Class01.QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Data
{
    public class UserRepository : DataBase
    {
        public Student GetStudentByUserName(string userName)
        {
            return Students.FirstOrDefault(student => student.UserName == userName);
        }

        public Teacher GetTeacherByUserName(string userName)
        {
            return Teachers.FirstOrDefault(teacher => teacher.UserName == userName);    
        }
        public List<Question> GetAllQuestions()
        {
            return Questions;
        }
    }
}
