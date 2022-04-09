using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class03.StaticClasses
{
    public static class StaticClass
    {
        public static int Counter = 1;

        public static int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
