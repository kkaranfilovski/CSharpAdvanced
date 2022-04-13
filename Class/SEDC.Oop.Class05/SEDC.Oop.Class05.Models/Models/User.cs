﻿using SEDC.Oop.Class05.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class05.Models.Models
{
    public class User
    {
        public static int IdCounter { get; set; } = 0;
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }

        public User(string userName, string password, Roles role)
        {
            Id = IdCounter++;
            UserName = userName;
            Password = password;
            Role = role;
        }

    }
}