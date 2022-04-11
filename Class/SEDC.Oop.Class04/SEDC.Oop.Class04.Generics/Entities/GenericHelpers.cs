using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.Generics.Entities
{
    public class GenericHelpers
    {
        public void GoThruWithGeneric<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfoWithGeneric<T>(List<T> list)
        {
            Console.WriteLine($"the list has {list.Count} elements and they are of type {list[0].GetType()}");
        }
    }
}
