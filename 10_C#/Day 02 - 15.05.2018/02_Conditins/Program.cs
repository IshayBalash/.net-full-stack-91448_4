using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditins
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = num1 * 6;



            //basic condition (<,>,==,!=,<=,>=)
            if (num1 > num2)
            {
                Console.WriteLine("num1 > num2");
            }

            else if (num1 < num2)
            {
                Console.WriteLine("num1 < num2");
            }

            else if (num1 >= num2)
            {
                Console.WriteLine("num1 >= num2");
            }

            else if (num1 <= num2)
            {
                Console.WriteLine("num1 <= num2");
            }

            else if (num1 == num2)
            {
                Console.WriteLine("num1 == num2");
            }

            else if (num1 != num2)
            {
                Console.WriteLine("num1 != num2");
            }





            //logical condition (<,>,==,!=,<=,>=)
            if (!(num1 == num2))
            {
                Console.WriteLine("!(num1 == num2)");
            }

            if ((num1 == num2) || (num1 < num2))
            {
                Console.WriteLine("(num1 == num2) || (num1 < num2)");

            }

            if ((num1 == num2) && (num1 < num2))
            {
                Console.WriteLine("(num1 == num2) && (num1 < num2)");

            }
        }
    }
}



/*
 
output:
--------------------    
num1 < num2
!(num1 == num2)
(num1 == num2) || (num1 < num2)
*/
