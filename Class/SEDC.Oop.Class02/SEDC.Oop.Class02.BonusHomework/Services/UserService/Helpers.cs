using SEDC.Oop.Class02.BonusHomework.Models;
using SEDC.Oop.Class02.BonusHomework.Services.Menus;

namespace SEDC.Oop.Class02.BonusHomework.Services.UserService
{

    //string brand, string model, string color, DateTime dop, bool isClean, bool isGasFull, bool isBroken

    public static class Helpers
    {
        public static string GetSelection ()
        {
            string selection = Console.ReadLine();
            return selection;
        }

        private static DateTime GetValidDate()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the date of your vehicle production in this format MM/dd/YYYY");
                    string date = Console.ReadLine();
                    bool isValidDate = DateTime.TryParse(date, out DateTime validDaite);

                    if (!isValidDate)
                    {
                        throw new Exception("Invalid date format. Please enter in this format MM/dd/YYYY");
                    }
                    else
                    {
                        return validDaite;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private static bool GetBool()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("enter 'y' for yes");
                    Console.WriteLine("enter 'n' for no");

                    string choice = Console.ReadLine();

                    if (choice == "y")
                    {
                        return true;
                    }
                    else if (choice == "n")
                    {
                        return false;
                    }
                    else
                    {
                        throw new Exception("invalid selection");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private static string VehcileChoice()
        {
            while (true)
            {
                try
                {
                    Screen.VehicleChoice();
                    string vehicleChoice = Console.ReadLine();

                    if (vehicleChoice == "1")
                    {
                        return "car";
                    }
                    else if (vehicleChoice == "2")
                    {
                        return "truck";
                    }
                    else
                    {
                        throw new Exception("invalid selection");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        public static Vehicle GetVehicleInfo()
        {
            while (true)
            {
                try
                {
                    string vehicle = VehcileChoice();

                    Console.WriteLine("Enter vehicle brand");
                    string brand = Console.ReadLine();

                    Console.WriteLine("Enter vehicle model");
                    string model = Console.ReadLine();

                    Console.WriteLine("Enter vehcile color");
                    string color = Console.ReadLine();

                    DateTime dateOfProduction = GetValidDate();

                    Console.WriteLine("Is your vehicle clean?");
                    bool isClean = GetBool();

                    Console.WriteLine("Do you need gas refill?");
                    bool pumpGas = GetBool();

                    Console.WriteLine("Does your vehicle need repairing?");
                    bool isBroken = GetBool();

                    if(vehicle == "car")
                    {
                        Car car = new Car(brand, model, color, dateOfProduction, isClean, pumpGas, isBroken);
                        return car;
                    }
                    else if(vehicle == "truck")
                    {
                        Truck truck = new Truck(brand, model, color, dateOfProduction, isClean, pumpGas, isBroken);
                        return truck;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }           
            }
        }
    }
}
