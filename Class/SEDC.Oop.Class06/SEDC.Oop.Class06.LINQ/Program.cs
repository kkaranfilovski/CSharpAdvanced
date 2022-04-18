// See https://aka.ms/new-console-template for more information

List<int> intList = new List<int> { 5, 6, 1, 4, 19, 32, 8, 14 };

var numGreaterThenTen = intList.Where(x => x > 10).ToList();

numGreaterThenTen.ForEach(x => Console.WriteLine(x));

List<string> stringList = new List<string> { "12", "2", "asd", "23", "44", "5", "8", "15"};

var convertedlist = stringList.Select(x => {
    
    int number;
    int.TryParse(x, out number);
    return number;

}).ToList();