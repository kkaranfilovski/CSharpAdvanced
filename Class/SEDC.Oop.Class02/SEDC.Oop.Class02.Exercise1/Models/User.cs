using SEDC.Oop.Class02.Exercise1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Exercise1.Models
{
    public abstract class User : IUser
    {
        public int Id { get; set ; }
        public string Name { get; set ; }
        public string UserName { get; set; }
        public string Password { get ; set; }

        public abstract void PrintUser();

        public User(int id, string name, string userName, string password)
        {
            Id = id;
            Name = name;
            UserName = userName;
            Password = password;
        }
    }


}
