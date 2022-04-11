using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.Extensions.Extensions
{
    public static class ListExtensions
    {
        public static void PrintElements<T>(this List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
