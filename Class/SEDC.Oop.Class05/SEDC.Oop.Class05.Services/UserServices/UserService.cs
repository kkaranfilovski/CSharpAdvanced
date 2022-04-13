using SEDC.Oop.Class05.Data;
using SEDC.Oop.Class05.Models.Enums;
using SEDC.Oop.Class05.Models.Models;
using SEDC.Oop.Class05.Services.Helpers;
using SEDC.Oop.Class05.Services.Interfaces;
using SEDC.Oop.Class05.Services.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class05.Services.UserServices
{
    public class UserService : IUser
    {

        public void LogIn()
        {
            while (true)
            {
                try
                {
                    string userName = Validations.GetUserName();
                    var user = InMemoryDatabase.GetUserByUserName(userName);

                    if(user != null)
                    {
                        if (Validations.ValidatePassword(user))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Successful Login! Welcome {user.Role}!");
                            Console.ResetColor();
                            
                            if(user.Role == Roles.Administrator)
                            {
                                Screens.AdminMenu();
                                break;
                            }
                            else if(user.Role == Roles.Maintenance)
                            {
                                Screens.MaintenanceMenu();
                                break;
                            }
                            else if(user.Role == Roles.Manager)
                            {
                                Screens.ManagerMenu();
                                break;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("invalid username. Try again!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void ChangePassword()
        {
            
        }
    }
}
