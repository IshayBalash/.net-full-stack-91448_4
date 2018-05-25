using System;

namespace _05_static_class
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(TimeChecker.getFullDate());

            Console.WriteLine(TimeChecker.DiffDate.TotalSeconds);

            for (int i = 0; i < Math.Pow(10,11); i++)
            {

            }
            Console.WriteLine(TimeChecker.DiffDate.TotalSeconds);
        }
    }
}






/*
OUTPUT:
____________________________________

12:36:31
0.0050034
0.0090054
     
 */
