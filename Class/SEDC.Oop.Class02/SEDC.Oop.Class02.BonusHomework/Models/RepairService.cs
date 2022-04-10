using SEDC.Oop.Class02.BonusHomework.Interfaces;

namespace SEDC.Oop.Class02.BonusHomework.Models
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            if (vehicle.IsBroken)
            {
                Console.WriteLine("Your vehicle is broken. We will fix it now");
                FixVehicle(vehicle);
                Console.WriteLine("You vehicle is fixed. You can drive without worries");
            }
            else
            {
                Console.WriteLine("Your vehicle is in good condition.");
            }
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Working on your {vehicle.Brand} {vehicle.Model}.....");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"YOur {vehicle.Brand} {vehicle.Model} is repaired.");
            Console.ResetColor();
            vehicle.IsBroken = false;
        }
    }
}
