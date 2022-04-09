using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class03.StaticClasses
{
    public class User
    {
        public static int UserCount { get; set; } = 0;

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public List<Order> Orders { get; set; }
        
        public User(int id, string name, string lname)
        {
            Id = id;
            Name = name;
            LastName = lname;
            UserCount++;
            Orders = new List<Order>();
        }

        public void PrintInfo()
        {
            Console.WriteLine(Name + " " + LastName + " " + UserCount);
        }

        public static void PrintUserCount()
        {
            Console.WriteLine(UserCount);
        }

        public void PrintOrders()
        {
            Console.WriteLine(Name);
            foreach (Order order in Orders)
            {
                order.Print();
            }
        }
    }
}
