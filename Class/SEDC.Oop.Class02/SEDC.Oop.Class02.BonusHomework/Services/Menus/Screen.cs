namespace SEDC.Oop.Class02.BonusHomework.Services.Menus
{
    public class Screen
    {
        public static void HomeScreen()
        {
            Console.WriteLine("Choose on the options bellow for your vehicle:");
            Console.WriteLine("1. Car wash");
            Console.WriteLine("2. Pump gas");
            Console.WriteLine("3. Repair");
            Console.WriteLine("4. Exit");
        }

        public static void VehicleChoice()
        {
            Console.WriteLine("Welcome to Vehicle Service");
            Console.WriteLine("Please choose your type of vehicle:");
            Console.WriteLine("1. car");
            Console.WriteLine("2. truck");
        }
    }
}
