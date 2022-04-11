using SEDC.Oop.Class04.Generics.Entities;

GenericMethods generic = new GenericMethods();

//generic.PrintObject("Something");
//generic.PrintObject<DateTime>(DateTime.Now);
//generic.PrintObject<int>(34);

NonGenericHelper nonGenericHelper = new NonGenericHelper();
GenericHelpers GenericHelpers = new GenericHelpers();

List<string> stringList = new List<string> { "Hello", "world", "Generic", "methods"};
List<int> intList = new List<int>() { 1,2,3,4,5};

Console.WriteLine("=========NON GENERIC=============");
nonGenericHelper.GoThruList(stringList);
nonGenericHelper.GetInfoForList(stringList);
nonGenericHelper.GoThruList(intList);
nonGenericHelper.GetInfoForList(intList);

Console.WriteLine("=============GENERIC=============");
GenericHelpers.GoThruWithGeneric(stringList);
GenericHelpers.GetInfoWithGeneric(stringList);
GenericHelpers.GoThruWithGeneric(intList);
GenericHelpers.GetInfoWithGeneric(intList);

Console.WriteLine("=============GENERIC CLASS=============");
GenericClass<double> genericClass = new GenericClass<double>(3.5);
genericClass.PrintPropertyTypeAndValue();

GenericDB<Product> productDB = new GenericDB<Product>();
productDB.Add(new Product { Id = 1, Title = "Book", Description = "C# Advanced" });
productDB.Add(new Product { Id = 2, Title = "Book 1", Description = "C# Basic" });
productDB.Add(new Product { Id = 3, Title = "Book 2", Description = "JS Basic" });
productDB.PrintInfo();

GenericDB<Order> orderDB = new GenericDB<Order>();
orderDB.Add(new Order { Id = 1, Adress = "Vlae", ProductName = new Product { Id = 1, Title = "Book", Description = "C# Advanced" } });
orderDB.Add(new Order { Id = 2, Adress = "Karpos", ProductName = new Product { Id = 2, Title = "Book1", Description = "C# Basic" } });
orderDB.Add(new Order { Id = 3, Adress = "Centar", ProductName = new Product { Id = 3, Title = "Book2", Description = "JS Basic" } });
orderDB.PrintInfo();

Product productForDelete = new Product() { Id = 4, Title = "Book3", Description = "css" };

productDB.DeleteItem(productForDelete);
productDB.Add(productForDelete);
productDB.DeleteItem(productForDelete);



