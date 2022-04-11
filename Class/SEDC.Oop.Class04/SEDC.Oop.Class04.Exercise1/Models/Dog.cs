namespace SEDC.Oop.Class04.Exercise1.Models
{
    public class Dog : Pet
    {


        public bool GoodBoi { get; set; }
        public string FavoriteFood { get; set; }

        public Dog(string name, string type, int age, bool isGoodBoi, string favFood)
            : base(name, type, age)
        {
            GoodBoi = isGoodBoi;
            FavoriteFood = favFood;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"The dog {Name} favorite food is {FavoriteFood}");
        }
    }
}
