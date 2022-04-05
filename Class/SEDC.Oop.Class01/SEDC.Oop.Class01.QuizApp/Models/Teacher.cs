using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Models
{
    public class Teacher : Person
    {
        public Teacher(string name, string userName, string password)
            :base(name, userName, password)
        {

        }
    }
}
