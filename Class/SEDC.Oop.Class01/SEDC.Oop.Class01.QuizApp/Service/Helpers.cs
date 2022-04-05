using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Service
{
    public class Helpers
    {
        public string GetUserName()
        {
            Console.WriteLine("Enter your username");
            string userName = Console.ReadLine();

            return userName;
        }

        public string GetPassword()
        {
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            return password;
        }

        public int GetAnswer()
        {
            while (true)
            {

                Console.WriteLine("Enter your answer");
                string answer = Console.ReadLine();

                bool isValid = int.TryParse(answer, out int parsedAnswer);

                if (!isValid || parsedAnswer < 1 || parsedAnswer > 4)
                {
                    Console.WriteLine("Pick valid number");
                    continue;
                }
                else
                {
                    return parsedAnswer;
                }
            }
        }
    }
}
