using SEDC.Oop.Class04.Extensions.Extensions;

Console.WriteLine(StringExtensions.DeleteLastCharacterWithoutExtension("abcde"));
string textToShorten = "Some text";

Console.WriteLine(textToShorten.DeleteLastCharacterWithExtension());
Console.WriteLine(textToShorten.AddQuataions());

List<string> list = new List<string>() { "first", "second" , "third" , "fourth" };
List<int> intList = new List<int>() { 1,2,3, 4, 5 };
list.PrintElements();
intList.PrintElements();