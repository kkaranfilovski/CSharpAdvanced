using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.Generics.Entities
{
    public class Order : BaseEntity
    {
        public Product ProductName { get; set; }
        public string Adress { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"{ProductName} - {Adress}");
        }
    }
}
