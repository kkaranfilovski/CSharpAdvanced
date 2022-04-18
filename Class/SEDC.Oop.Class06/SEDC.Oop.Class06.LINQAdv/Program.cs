// See https://aka.ms/new-console-template for more information

List<Order> orders = new List<Order>
{
    new Order() { Id = 1, Name = "Order1", OrderStatus = OrderStatus.Proccessing, Quantity = 1 },
    new Order() { Id = 9, Name = "Order9", OrderStatus = OrderStatus.Shipped, Quantity = 10 },
    new Order() { Id = 5, Name = "Order6", OrderStatus = OrderStatus.Proccessing, Quantity = 12 },
    new Order() { Id = 4, Name = "Order4", OrderStatus = OrderStatus.Delivered, Quantity = 8 },
    new Order() { Id = 10, Name = "Order10", OrderStatus = OrderStatus.Proccessing, Quantity = 75 },
    new Order() { Id = 8, Name = "Order8", OrderStatus = OrderStatus.Proccessing, Quantity = 13 },
    new Order() { Id = 3, Name = "Order3", OrderStatus = OrderStatus.Delivered, Quantity = 512 },
    new Order() { Id = 2, Name = "Order2", OrderStatus = OrderStatus.Proccessing, Quantity = 6 },
    new Order() { Id = 7, Name = "Order7", OrderStatus = OrderStatus.Delivered, Quantity = 99 },
    new Order() { Id = 6, Name = "Order6", OrderStatus = OrderStatus.Shipped, Quantity = 100 },
};

List<Order> copyList = orders.Select(x => x).ToList();
copyList.FirstOrDefault(x => x.Id == 1).Name = "Order1 Changed";
copyList.FirstOrDefault(x => x.Id == 4).Name = "Order4 Changed";

Console.WriteLine("Origianl list===================================");
orders.ForEach(x => global::System.Console.WriteLine(x));

Console.WriteLine("Copied list=====================================");
copyList.ForEach(x => global::System.Console.WriteLine(x));

Console.WriteLine("REAL COPY LIST===================================");
var realCopyList = orders.Select(x => new Order
{
    Id = x.Id,
    Name = x.Name,
    OrderStatus = x.OrderStatus,
    Quantity = x.Quantity,
}).ToList();

realCopyList.FirstOrDefault(x => x.Id == 1).Name = "Order11111";

realCopyList.ForEach(x => global::System.Console.WriteLine(x));

Console.WriteLine("=======================================SUM===============================================");
int sumOfQuantities = orders.Sum(x => x.Quantity);
Console.WriteLine(sumOfQuantities);

Console.WriteLine("=======================================MAX===============================================");
var orderWithMaxQuantity = orders.FirstOrDefault(x => x.Quantity == orders.Max(x => x.Quantity));
Console.WriteLine(orderWithMaxQuantity);

Console.WriteLine("=======================================AVERAGE===============================================");
var averageQuantity = orders.Average(x => x.Quantity);
List<Order> AboveAverage = orders.Where(x => x.Quantity > averageQuantity).ToList();
Console.WriteLine(averageQuantity);
AboveAverage.ForEach(x => Console.WriteLine(x));

Console.WriteLine("=======================================ORDER ASC===============================================");
var ascOrderedList = orders.OrderBy(x => x.Id).ToList();
ascOrderedList.ForEach(x => Console.WriteLine(x));

Console.WriteLine("=======================================ENUMS ASC===============================================");
var enumsList = orders.OrderBy(x => x.OrderStatus).ToList();
enumsList.ForEach(x => Console.WriteLine(x));

Console.WriteLine("=======================================STRING ASC===============================================");
var stringList = orders.OrderBy(x => x.Name).ToList();
stringList.ForEach(x => Console.WriteLine(x));

Console.WriteLine("=======================================ORDER DESC===============================================");
var descOrderedList = orders.OrderByDescending(x => x.Id).ToList();
descOrderedList.ForEach(x => Console.WriteLine(x));

Console.WriteLine("=======================================GROUP BY===============================================");
var groupByList = orders.GroupBy(x => x.OrderStatus).ToList();
foreach (var groupBy in groupByList)
{
    Console.WriteLine(groupBy.Key);
    foreach(var order in groupBy)
    {
        Console.WriteLine(order);
    }
}

public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public OrderStatus OrderStatus { get; set; }

    public override string ToString()
    {
        return $"{Id} Name: {Name} Quantity: {Quantity} Order Status: {OrderStatus}";
    }
}

public enum OrderStatus
{
    Proccessing,
    Shipped,
    Delivered
}

