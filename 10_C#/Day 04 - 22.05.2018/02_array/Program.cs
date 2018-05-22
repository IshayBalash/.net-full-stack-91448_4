using System;

namespace _02_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1,4,2,3 };
            Console.Write("Original Array: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // reverse the array
            Array.Reverse(list);
            Console.Write("Reversed Array: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //sort the array
            Array.Sort(list);
            Console.Write("Sorted Array: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}


/*
OUTPUT:
_________________________________

Original Array: 1 4 2 3
Reversed Array: 3 2 4 1
Sorted Array: 1 2 3 4
 
     
*/
