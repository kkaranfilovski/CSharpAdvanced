// See https://aka.ms/new-console-template for more information


List<string> nameList = new List<string>();

Console.WriteLine("Enter names. When you want to stop enter X");
while (true)
{
    string nameInput = Console.ReadLine();

    if(nameInput.ToLower() == "x")
    {
        break;
    }
    else
    {
        nameList.Add(nameInput);
    }
}

Console.WriteLine("Enter text to check how many times do the names you entered appear in the text");
string text = Console.ReadLine();

foreach (string name in nameList)
{
    int count = text.ToLower().Split(name).Length - 1;
    Console.WriteLine($"The name {name} appears {count} times");
}




