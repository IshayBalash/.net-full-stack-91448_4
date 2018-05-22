using System;

namespace _03_array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] mat = { { 1, 4, 2, 3 }, { 1, 4, 2, 3 } };
            Console.WriteLine($"list rank is:{mat.Rank}");

            int[] list = { 1, 4, 2, 3 };
            int[] listCopy = new int[4];

            Console.WriteLine( $"list rank is:{list.Rank}");
            Console.Write("Original Array: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            list.CopyTo(listCopy, 0);
            // reverse the array
            Array.Reverse(listCopy);
            Console.Write("Reversed Array: ");

            foreach (int i in listCopy)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //sort the array
            Array.Sort(listCopy);
            Console.Write("Sorted Array: ");

            foreach (int i in listCopy)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.Write("Original Array: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}

/*

OUTPUT:
_____________________________

list rank is:2
list rank is:1
Original Array: 1 4 2 3
Reversed Array: 3 2 4 1
Sorted Array: 1 2 3 4
Original Array: 1 4 2 3  
     
 */
