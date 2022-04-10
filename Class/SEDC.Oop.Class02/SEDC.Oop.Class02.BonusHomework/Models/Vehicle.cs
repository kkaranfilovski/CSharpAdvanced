namespace SEDC.Oop.Class02.BonusHomework.Models
{
    public abstract class Vehicle
    {
        public string Brand  { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public DateTime DateOfProduction { get; set; }
        public bool IsClean { get; set; }
        public bool GasRefill { get; set; }
        public bool IsBroken { get; set; }

        public abstract void Drive();

        public Vehicle(string brand, string model, string color, DateTime dop, bool isClean, bool gasRefill, bool isBroken)
        {
            Brand = brand;
            Model = model;
            Color = color;
            DateOfProduction = dop;
            IsClean = isClean;
            GasRefill = gasRefill;
            IsBroken = isBroken;
        }
    }
}




