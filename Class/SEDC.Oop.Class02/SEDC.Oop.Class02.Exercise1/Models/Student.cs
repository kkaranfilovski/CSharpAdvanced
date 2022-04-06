using SEDC.Oop.Class02.Exercise1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Exercise1.Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }
        public Student(int id, string name, string userName, string password, List<int> grades) 
            : base(id, name, userName, password)
        {
            Grades = grades;
        }

        public override void PrintUser()
        {
            Console.WriteLine("Your grades:");
            foreach (var grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
