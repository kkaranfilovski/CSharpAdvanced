// See https://aka.ms/new-console-template for more information


Console.WriteLine("======= FUNC =======");
Func<int> getRandomNumber = () =>
{
    Random random = new Random();
    return random.Next(1,100);
};

static int GetRandomNumber()
{
    Random random = new Random();
    return random.Next(1, 100);
}

//Console.WriteLine(getRandomNumber());
//Console.WriteLine(GetRandomNumber());

Func<int, int, int> addTwoNumbers = (num1, num2) => num1 + num2;
Func<string, bool> isValidNumber = (text) => int.TryParse(text, out int number);

//string firstNum = Console.ReadLine();
//string secondNum = Console.ReadLine();

//if(isValidNumber(firstNum) && isValidNumber(secondNum))
//{
//    int first = int.Parse(firstNum);
//    int second = int.Parse(secondNum);
//    Console.WriteLine(addTwoNumbers(first, second));
//}
//else
//{
//    Console.WriteLine("not valid numbers");
//}

Console.WriteLine("======= ACTION =======");

//Action printSum = () => Console.WriteLine(addTwoNumbers(int.Parse(firstNum), int.Parse(secondNum)));
//printSum();

Action printHelloMessage = () => Console.WriteLine("Hello from action method");
printHelloMessage();

Action<string> printRedColor = (text) =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
};

printRedColor("ERRORRRRRRRRRRRRRRRRRRR");

Action<string, ConsoleColor> printWithColor = (text, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
};

printWithColor("SUCCES", ConsoleColor.Green);
printWithColor("ERROR", ConsoleColor.Red);
