using SEDC.Oop.Class05.Models.Models;
using SEDC.Oop.Class05.Services.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class05.Services.UserServices
{
    public class AdminService
    {
        public void AdminMenu()
        {
            Screens.AdminMenu();
            string selection = Console.ReadLine();

            if(selection == "1")
            {
                AddNewUser();
            }
            else if(selection == "2")
            {
                RemoveUser();
            }
            else if (selection == "3")
            {
                
            }
        }

        private void AddNewUser()
        {

        }

        private void RemoveUser()
        {

        }
    }
}
