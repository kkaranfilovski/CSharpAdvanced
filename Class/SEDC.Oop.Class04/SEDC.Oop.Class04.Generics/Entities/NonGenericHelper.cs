using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.Generics.Entities
{
    public class NonGenericHelper
    {
        public void GoThruList(List<string> strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        public void GoThruList(List<int> integers)
        {
            foreach(int i in integers)
            {
                Console.WriteLine(i);
            }
        }

        public void GetInfoForList(List<string> strings)
        {
            Console.WriteLine($"the list has {strings.Count} elements and they are of type {strings[0].GetType()}");
        }

        public void GetInfoForList(List<int> list)
        {
            Console.WriteLine($"the list has {list.Count} elements and they are of type {list[0].GetType()}");
        }


    }
}
