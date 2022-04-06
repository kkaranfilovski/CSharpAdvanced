using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Entities.Interface
{
    public class User : IUser
    {
        public int Id { get; set; }

        public User(int id)
        {
            Id = id;
        }

        public string GetID()
        {
            return $"Your ID is {Id}";
        }
    }
}
