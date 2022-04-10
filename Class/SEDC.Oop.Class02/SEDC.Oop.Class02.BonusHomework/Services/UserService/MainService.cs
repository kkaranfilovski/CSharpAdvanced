using SEDC.Oop.Class02.BonusHomework.Models;
using SEDC.Oop.Class02.BonusHomework.Services.Menus;

namespace SEDC.Oop.Class02.BonusHomework.Services.UserService
{
    public class MainService
    {
        private CarCenter carCenter = new CarCenter();

        public void Main()
        {
            Home();
        }

        private void Home()
        {
            var vehicle = Helpers.GetVehicleInfo();
            Console.Clear();
            while (true)
            {
                Console.WriteLine("");
                Screen.HomeScreen();
                Console.WriteLine("");
                string selection = Helpers.GetSelection();

                if(selection == "1")
                {
                    if(vehicle.GetType() == typeof(Car))
                    {
                        carCenter.WashCar(vehicle);
                        Console.WriteLine("");
                    }
                    else if(vehicle.GetType() == typeof(Truck))
                    {
                        carCenter.WashTrailer(vehicle);
                        Console.WriteLine("");
                    }
                }
                else if(selection == "2")
                {
                    carCenter.PumpGas(vehicle);
                    continue;
                }
                else if(selection == "3")
                {
                    carCenter.CheckVehicle(vehicle);
                    continue;
                }
                else if(selection == "4")
                {
                    Console.WriteLine("Thanks for using our services. See you soon :)");
                    vehicle.Drive();
                    Thread.Sleep(1500);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Try again");
                    continue;
                }
            }
        }
    }
}
