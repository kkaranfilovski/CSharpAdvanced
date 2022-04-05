using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int LoginAttempts { get; set; }

        public Person(string name, string userName, string password)
        {
            FullName = name;
            UserName = userName;
            Password = password;
            LoginAttempts = 3;
        }
    }
}
