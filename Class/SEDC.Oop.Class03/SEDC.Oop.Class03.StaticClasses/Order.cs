using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class03.StaticClasses
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public Order(int id, string title, string desc, OrderStatus status)
        {
            Id = id;
            Title = title;
            Description = desc;
            OrderStatus = status;
        }

        public void Print()
        {
            Console.WriteLine($"{StringHelper.CapitalizeFirstLetter(Title)} - {Description}");
        }
    }

    public enum OrderStatus
    {
        Processiong,
        SHipped,
        Delivered
    }
}
