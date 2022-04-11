using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.Generics.Entities
{
    public class GenericDB<T> where T : BaseEntity
    {
        private List<T> items;

        public GenericDB()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
            Console.WriteLine($"New item of type{typeof(T)} was added.");
        } 

        public void PrintInfo()
        {
            foreach (T item in items)
            {
                item.PrintInfo();
            }
        }

        public void DeleteItem(T item)
        {
            T item1 = items.FirstOrDefault(x => x == item);
            
            if (item != null)
            {
                items.Remove(item);
                Console.WriteLine($"Item {item.Id} was removed.");
            }
            else
            {
                Console.WriteLine("There isnt such item.");
            }
        }
    }
}
