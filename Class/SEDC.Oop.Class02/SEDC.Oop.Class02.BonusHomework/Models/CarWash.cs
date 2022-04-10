using SEDC.Oop.Class02.BonusHomework.Interfaces;

namespace SEDC.Oop.Class02.BonusHomework.Models
{
    public class CarWash : ICarWash
    {
        public void WashCar(Vehicle car)
        {
            if (car.IsClean)
            {
                Console.WriteLine("Your car is clean. You dont need to wash it");
            }
            else
            {
                Console.WriteLine("Washing the car......");
                Thread.Sleep(2000);
                Console.WriteLine("Your car is clean.");
                car.IsClean = true;
            }
        }

        public void WashTrailer(Vehicle truck)
        {
            if (truck.IsClean)
            {
                Console.WriteLine("Your truck is clean. You dont need to wash it");
            }
            else
            {
                Console.WriteLine("Washing the truck......");
                Thread.Sleep(4000);
                Console.WriteLine("Your truck is clean.");
                truck.IsClean = true;
            }
        }
    }
}
