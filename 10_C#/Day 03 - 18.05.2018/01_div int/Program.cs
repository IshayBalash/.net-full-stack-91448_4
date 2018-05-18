using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_div_int
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3, num2 = 2;
            double res;

            res = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {res}");  //--> 3 / 2 = 1


            res = 1.0 *num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {res}");  //--> 3 / 2 = 1.5

            res = (0.0 + num1) / num2;
            Console.WriteLine($"{num1} / {num2} = {res}");  //--> 3 / 2 = 1.5

            res =  num1 / num2 * 1.0;
            Console.WriteLine($"{num1} / {num2} = {res}");  //--> 3 / 2 = 1


            res = num1 / (num2 * 1.0);
            Console.WriteLine($"{num1} / {num2} = {res}");  //--> 3 / 2 = 1.5


            res = (double)num1/ num2;   //המרה מפורשת לטיפוס עשרוני ולא לטיפוס שלם

            Console.WriteLine($"{num1} / {num2} = {res}");  //--> 3 / 2 = 1.5


            res = (double)(num1 / num2);   // (num1 / num2) was implemented first - and gave an int result

            Console.WriteLine($"{num1} / {num2} = {res}");  //--> 3 / 2 = 1


        }
    }
}
