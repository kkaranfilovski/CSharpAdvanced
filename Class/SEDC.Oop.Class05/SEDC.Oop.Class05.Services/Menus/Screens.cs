using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class05.Services.Menus
{
    public static class Screens
    {
        public static void WelcomeMenu()
        {
            Console.WriteLine("Taxi Manager 9000");
            Console.WriteLine("Log in:");
        }

        public static void AdminMenu()
        {
            Console.WriteLine("Enter a number to choose one of the following:");
            Console.WriteLine("1. Remove existing user");
            Console.WriteLine("2. Add new user");
            Console.WriteLine("3. Change password");
            Console.WriteLine("4. Exit");
        }

        public static void ManagerMenu()
        {
            Console.WriteLine("Enter a number to choose one of the following:");
            Console.WriteLine("1. List all drivers");
            Console.WriteLine("2. License Status");
            Console.WriteLine("3. Driver manager");
            Console.WriteLine("4. Change password");
            Console.WriteLine("5. Exit");
        }

        public static void MaintenanceMenu()
        {
            Console.WriteLine("Enter a number to choose one of the following:");
            Console.WriteLine("1. List all vehicles");
            Console.WriteLine("2. License plate status");
            Console.WriteLine("3. Change password");
            Console.WriteLine("4. Exit");
        }
    }
}
