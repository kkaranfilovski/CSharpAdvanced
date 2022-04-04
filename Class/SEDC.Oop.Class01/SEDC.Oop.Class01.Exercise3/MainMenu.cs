using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.Exercise3
{
    public class MainMenu
    {
        Database database = new Database(); 
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Rock Paper Sccisors");
                Console.WriteLine("Select option:");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Stats");
                Console.WriteLine("3. Exit");

                string selection = Console.ReadLine();

                if (selection == "1")
                {
                    Play();
                    continue;
                }
                else if (selection == "2")
                {                    
                    Stats();
                    continue;
                }
                else if (selection == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Choose valid option");
                    continue;
                }
            }
        }
        private void Play()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Pick one of the options:");
                Console.WriteLine("1. rock");
                Console.WriteLine("2. paper");
                Console.WriteLine("3. sccisors");
                Console.WriteLine("4. Go to main menu");
                Console.WriteLine("");

                string selection = Console.ReadLine();
                bool isValid = int.TryParse(selection, out int userSelection);

                if (!isValid || userSelection < 1 || userSelection > 4)
                {
                    Console.WriteLine("Enter valid number");
                    continue;
                }
                int appSelection = new Random().Next(1, 3);

                if (userSelection == 1)
                {
                    if (appSelection == 1)
                    {
                        showText(1, 1);
                        Console.WriteLine("Even");
                        database.Even++;
                        continue;
                    }
                    else if (appSelection == 2)
                    {
                        showText(1, 2);
                        Console.WriteLine("You lose");
                        database.AppWin++;
                        continue;
                    }
                    else if (appSelection == 3)
                    {
                        showText(1, 3);
                        Console.WriteLine("You win");
                        database.UserWin++;
                        continue;
                    }
                }
                else if (userSelection == 2)
                {
                    if (appSelection == 1)
                    {
                        showText(2, 1);
                        Console.WriteLine("You win");
                        database.UserWin++;
                        continue;
                    }
                    else if (appSelection == 2)
                    {
                        showText(2, 2);
                        Console.WriteLine("Even");
                        database.Even++;
                        continue;
                    }
                    else if (appSelection == 3)
                    {
                        showText(2, 3);
                        Console.WriteLine("You lose");
                        database.AppWin++;
                        continue;
                    }
                }
                else if (userSelection == 3)
                {
                    if (appSelection == 1)
                    {
                        showText(3, 1);
                        Console.WriteLine("You lose");
                        database.AppWin++;
                        continue;
                    }
                    else if (appSelection == 2)
                    {
                        showText(3, 2);
                        Console.WriteLine("You win");
                        database.UserWin++;
                        continue;
                    }
                    else if (appSelection == 3)
                    {
                        showText(3, 3);
                        Console.WriteLine("Even");
                        database.Even++;
                        continue;
                    }
                }
                else if(userSelection == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Choose valid option");
                    continue;
                }
            }
        }
        private void Stats()
        {
            Console.WriteLine($"User wins: {database.UserWin}");
            Console.WriteLine($"Computer wins: {database.AppWin}");
            Console.WriteLine($"Even games: {database.Even}");
        }

        List<string> Options = new List<string> 
        { 
            "rock", "paper", "scissors"
        };

        private void showText(int userChoice, int appChoice)
        {
            Console.WriteLine("");
            Console.WriteLine($"You choose: {Options[userChoice - 1]}");
            Console.WriteLine($"PC choose: {Options[appChoice - 1]}");
        }
    }
}
