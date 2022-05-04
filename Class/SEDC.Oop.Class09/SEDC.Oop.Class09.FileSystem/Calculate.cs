using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class09.FileSystem
{
    public static class Calculate
    {
        public static int Add(int num1, int num2) => num1 + num2;
        public static int Divide(int num1, int num2) => num1 / num2;
        public static int Multiply(int num1, int num2) => num1 * num2;
        public static int Subtract(int num1, int num2) => num1 - num2;

        public static int Execute(int first, int second, Operation operation)
        {
            var result = operation switch
            {
                Operation.Add => Calculate.Add(first, second),
                Operation.Subtract => Calculate.Subtract(first, second),
                Operation.Multiply => Calculate.Multiply(first, second),
                Operation.Divide => Calculate.Divide(first, second),
                _ => throw new InvalidOperationException("Invalid operation"),
            };

            Console.WriteLine(result);

            Logger.Log(first, second, operation, result);

            return result;
        }
    }
}
