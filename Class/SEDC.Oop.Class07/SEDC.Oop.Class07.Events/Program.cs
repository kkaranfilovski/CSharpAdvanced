using SEDC.Oop.Class07.Events.Entities;

Market tineks = new Market()
{
    Name = "Tineks",
    CurrentProduct = ProductType.Food
};

Market reptil = new Market()
{
    Name = "Reptil",
    CurrentProduct = ProductType.Cosmetics
};

Market neptun = new Market()
{
    Name = "Neptun",
    CurrentProduct = ProductType.Electornic
};

User kristijan = new User("Kristijan", "Karanfilovski", 26, "kiko@gmail.com");
User ivan = new User("Ivan", "Djikovski", 29, "vlatko@gmail.com");
User petko = new User("Petko", "Petkovski", 30, "petko@gmail.com");
User stanko = new User("Stanko", "Stankovski", 20, "stanko@gmail.com");

tineks.SubscribeToPromotion(ivan.ReadPromotion, ivan.Email);
tineks.SubscribeToPromotion(kristijan.ReadPromotion, kristijan.Email);
tineks.Send();

Console.WriteLine("===================================================");
tineks.Unsubscribe(ivan.ReadPromotion, ivan.Email);
tineks.Send();

Console.WriteLine("==================================================");
neptun.SubscribeToPromotion(petko.ReadPromotion, ivan.Email);
neptun.SubscribeToPromotion(stanko.ReadPromotion, stanko.Email);
neptun.Send();

Console.WriteLine("==================================================");
reptil.SubscribeToPromotion(ReadPromotion, "Console");



reptil.Send();

static void ReadPromotion(ProductType type, string marketName)
{
    Console.WriteLine($"Subscription from main method. Promotion for {type} at {marketName}.");
}