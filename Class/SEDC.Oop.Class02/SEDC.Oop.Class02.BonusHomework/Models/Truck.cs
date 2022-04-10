namespace SEDC.Oop.Class02.BonusHomework.Models
{
    public class Truck : Vehicle
    {
        public Truck(string brand, string model, string color, DateTime dop, bool isClean, bool gasRefill, bool isBroken) 
            : base(brand, model, color, dop, isClean, gasRefill, isBroken)
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"The truck {Brand} {Model} is driving away from the service...");
        }
    }
}
