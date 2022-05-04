using SEDC.Oop.Class09.FileSystem;

var reader = new ConsoleReading();
var first = reader.ReadInteger();
var second = reader.ReadInteger();
var operation = reader.ReadOperation();

var result = Calculate.Execute(first, second, operation);

Console.WriteLine(result);

