// See https://aka.ms/new-console-template for more information

List<DateTime> dates = new List<DateTime>
{
    new DateTime(2022, 1, 1),
    new DateTime(2022, 1, 7),
    new DateTime(2022, 4, 20),
    new DateTime(2022, 5, 25),
    new DateTime(2022, 8, 3),
    new DateTime(2022, 9, 8),
    new DateTime(2022, 10, 23),
    new DateTime(2022, 12, 8)
    
};

Console.WriteLine("Enter a date to check if is it non working day:");
string date = Console.ReadLine();

bool isValid = DateTime.TryParse(date, out DateTime validDate);

if (!isValid)
{
    Console.WriteLine("Invalid date");
}
else
{
    var foundDate = dates.Any(x => x.Day == validDate.Day && x.Month == validDate.Month);


    if(validDate.DayOfWeek == DayOfWeek.Sunday || validDate.DayOfWeek == DayOfWeek.Saturday || foundDate)
    {
        Console.WriteLine("Non working day");
    }
    else
    {
        Console.WriteLine("Working day");
    }
}

//1 January, 7 January, 20 April, 1 May, 25 May, 3 August, 8 September, 12 October, 23 October, and 8 December are not working days as well
