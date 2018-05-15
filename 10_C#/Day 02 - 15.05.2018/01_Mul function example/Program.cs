using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mul_function_example
{
    class Program
    {

        static int MulNum(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            int num1, num2, result;

            Console.WriteLine("please enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = MulNum(num1, num2);

            Console.WriteLine($"the result of {num1}*{num2} is: {result}");
        }
    }
}
