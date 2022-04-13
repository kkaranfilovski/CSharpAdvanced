using SEDC.Oop.Class05.Models.Enums;
using SEDC.Oop.Class05.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class05.Data
{
    public static class InMemoryDatabase
    {
        private static List<Car> Cars { get; set; }
        private static List<Driver> Drivers { get; set; }
        private static List<User> Users { get; set; }

        static InMemoryDatabase()
        {
            InitDatabase();
        }

        private static void InitDatabase()
        {
            Cars = new List<Car>
            {
                new Car("ford fiesta", "SK5631AZ", new DateTime(2022,11,15)),
                new Car("Citroen c3", "SK2222PP", new DateTime(2023, 3, 3))
            };

            Users = new List<User>
            {
                new User("admin1", "admin1", Roles.Administrator),
                new User("bobsky", "bobsky1", Roles.Manager),
                new User("petko", "petko1", Roles.Maintenance)
            };

            Drivers = new List<Driver>
            {
                new Driver("kristijan", "karanfilovski", Shifts.Morning, "ASD123", new DateTime(2024, 5, 3)),
                new Driver("ilija", "mitev", Shifts.Afternoon, "QWE123", new DateTime(2025, 5, 10))
            };
        }

        public static User GetUserByUserName(string userName)
        {
            return Users.FirstOrDefault(user => user.UserName == userName);
        }
    }
}
