using SEDC.Oop.Class05.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class05.Services.Helpers
{
    public static class Validations
    {
        public static string GetUserName()
        {
            Console.WriteLine("Enter username");
            string userName = Console.ReadLine();
            return userName;
        }

        public static bool ValidatePassword(User user)
        {
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            if(user.Password == password)
            {
                return true;
            }
            else
            {
                throw new Exception("Invalid password. Try again");
            }
        }
    }
}
