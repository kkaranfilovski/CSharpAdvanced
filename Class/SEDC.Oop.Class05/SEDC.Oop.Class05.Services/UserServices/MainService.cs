using SEDC.Oop.Class05.Services.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class05.Services.UserServices
{
    public class MainService
    {
        private UserService userService = new UserService();

        public void Main()
        {
            Screens.WelcomeMenu();
            userService.LogIn();
        }
    }
}
