SayDelegate sayDelegate = new SayDelegate(WriteToConsole);
SayDelegate sayWithColor = new SayDelegate(WriteWithRedColor);

sayDelegate("Hello world from delegate");
sayWithColor("This text is red");

SaySomething(WriteWithRedColor, 1);
SaySomething(WriteToConsole, 3);

CalculateDelegate addNumbers = AddTwoNumbers;
CalculateDelegate subtractNums = SubtractTwoNumbers;

Console.WriteLine(addNumbers(4, 5));
Console.WriteLine(subtractNums(5,4));

PerformCalculations(addNumbers, subtractNums, 6, 7);

DelegatesCalcAction(5, 3, (num1, num2) => num1 + num2);

static void WriteToConsole(string text)
{
    Console.WriteLine(text);
};

static void WriteWithRedColor(string text)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
}

static int AddTwoNumbers(int num1, int num2)
{
    return num1 + num2;
}

static int SubtractTwoNumbers(int num1, int num2)
{
    return num1 - num2;
}

static void SaySomething(SayDelegate sayMech, int counter)
{
    sayMech($"Text from method {counter}");
}

static void PerformCalculations(CalculateDelegate addNums, CalculateDelegate subNums, int num1, int num2)
{
    Console.WriteLine($"Addition of {num1} and {num2} is {addNums(num1, num2)}");
    Console.WriteLine($"Subtraction of {num1} and {num2} is {subNums(num1, num2)}");
};

static void DelegatesCalcAction(int num1, int num2, CalculateDelegate del)
{
    Console.WriteLine(del(num1, num2));
}

delegate void SayDelegate(string text);
delegate int CalculateDelegate(int num1, int num2);

