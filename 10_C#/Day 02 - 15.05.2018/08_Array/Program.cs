using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool --> false
            Console.WriteLine("------------boolArray--------------");
            bool[] boolArray = new bool[2];
            foreach (bool item in boolArray)
            {
                Console.WriteLine(item);
            }

            //char --> `\0` (ascii code of 0)
            Console.WriteLine("------------charArray--------------");
            char[] charArray = new char[2];
            foreach (char item in charArray)
            {
                Console.WriteLine(item);
            }

            //int --> 0
            Console.WriteLine("------------intArray--------------");
            int[] intArray = new int[2];
            foreach (int item in intArray)
            {
                Console.WriteLine(item);
            }


            //string --> null
            Console.WriteLine("------------stringArray--------------");
            string[] stringArray = new string[2];
            foreach (string item in stringArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
