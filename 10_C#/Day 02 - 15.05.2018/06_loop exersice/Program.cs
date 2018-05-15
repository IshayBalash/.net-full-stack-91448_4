using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_loop_exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a string:");
            string str = Console.ReadLine();

            if (str.Length <= 5)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if(i%2==0)
                        Console.WriteLine(str[i]);
                }
            }
            else
            {
                foreach (char item in str)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
