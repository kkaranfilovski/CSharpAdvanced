using SEDC.Oop.Class02.BonusHomework.Interfaces;

namespace SEDC.Oop.Class02.BonusHomework.Models
{
    public class GasPump : IGasPump
    {
        public void PumpGas(Vehicle vehicle)
        {
            if (!vehicle.GasRefill)
            {
                Console.WriteLine("Your gas tank is full");
            }
            else
            {
                Console.WriteLine("Pumping gas......");
                Thread.Sleep(1500);
                Console.WriteLine("Your gas tank is now full. You can drive");
                vehicle.GasRefill = false;
            }
        }
    }
}
