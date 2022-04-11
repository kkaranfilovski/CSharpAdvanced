using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.Generics.Entities
{
    public class GenericMethods
    {
        public void PrintObject<T>(T objectPrint)
        {
            Console.WriteLine(objectPrint);
        }
    }
}
