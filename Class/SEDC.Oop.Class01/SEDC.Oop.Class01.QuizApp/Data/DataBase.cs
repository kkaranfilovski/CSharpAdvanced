using SEDC.Oop.Class01.QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.QuizApp.Data
{
    public class DataBase
    {
        public static List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Question> Questions { get; set; }

        public DataBase()
        {
            InitDatabase();
        }

        public void InitDatabase()
        {
            Students = new List<Student>
            {
                new Student("Kristijan Karanfilovski", "krikar", "kiko123"),
                new Student("Ilija Mitev", "ilemit", "ile123"),
                new Student("Igor Nikoloski", "igonik", "igor123"),
                new Student("Stefan Ivanovski", "steiva", "stefan123")
            };

            Teachers = new List<Teacher>
            {
                new Teacher("Ivan Dzikovski", "ivand", "ivan123"),
                new Teacher("Vlatko Tasevski", "vlatas", "vlatko123")
            };

            Questions = new List<Question>
            {
                new Question
                (
                    "What is the capital of Tasmania?",
                    new List<Answer>
                    {
                    new Answer(1,"Dodoma", false),
                    new Answer(2,"Hobart" , true),
                    new Answer(3,"Launceston", false),
                    new Answer(4,"Wellington", false)
                    }

                ),
                new Question
                (
                    "What is the tallest building in the Republic of the Congo?",
                    new List<Answer>
                    {
                    new Answer(1,"Kinshasa Democratic Republic of the Congo Temple", false),
                    new Answer(2,"Palais de la Nation" , false),
                    new Answer(3,"Kongo Trade Centre", false),
                    new Answer(4,"Nabemba Towe", true)
                    }

                ),
                new Question
                (
                    "Which of these is not one of Pluto's moons?",
                    new List<Answer>
                    {
                    new Answer(1,"Styx", false),
                    new Answer(2,"Hydra" , false),
                    new Answer(3,"Nix", true),
                    new Answer(4,"Lugia", false)
                    }
                ),
                new Question
                (
                    "What is the smallest lake in the world?",
                    new List<Answer>
                    {
                    new Answer(1,"Onega Lake", false),
                    new Answer(2,"Benxi Lake" , true),
                    new Answer(3,"Kivu Lake", false),
                    new Answer(4,"Wakatipu Lake", false)
                    }
                ),
                new Question
                (
                    "What country has the largest population of alpacas?",
                    new List<Answer>
                    {
                    new Answer(1,"Chad", false),
                    new Answer(2,"Peru" , true),
                    new Answer(3,"Australia", false),
                    new Answer(4,"Niger", false)
                    }
                )
            };
        }
    }
}
