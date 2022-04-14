using SEDC.Oop.Class05.Models.Enums;
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
        private AdminService adminService = new AdminService();

        public void Main()
        {
            while (true)
            {
                Screens.WelcomeMenu();
                var user = userService.LogIn();

                if (user.Role == Roles.Administrator)
                {
                    adminService.AdminMenu(user);
                }
                else if (user.Role == Roles.Maintenance)
                {
                    Screens.MaintenanceMenu();
                }
                else if (user.Role == Roles.Manager)
                {
                    Screens.ManagerMenu();
                }
            }
        }
    }
}
