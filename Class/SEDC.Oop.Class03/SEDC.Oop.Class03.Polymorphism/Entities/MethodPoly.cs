using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class03.Polymorphism.Entities
{
    public static class MethodPoly
    {
        public static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int AddNumbers(int num1, int num2, int num3)
        {
            return (num1 + num2) + num3;
        }

        public static void AddNumbers(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
}
