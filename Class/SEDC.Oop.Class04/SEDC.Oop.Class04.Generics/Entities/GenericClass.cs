using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.Generics.Entities
{
    public class GenericClass<T>
    {
        public T MyCustomProperty { get; set; }

        public GenericClass(T myProperty)
        {
            MyCustomProperty = myProperty;
        }

        public void PrintPropertyTypeAndValue()
        {
            Console.WriteLine($"The property is of type {MyCustomProperty.GetType()} and the value is {MyCustomProperty}");
        }
    }
}
