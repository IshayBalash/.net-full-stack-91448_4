//IEnumerable is an interface that can point to any object that implements the IEnumerable interface
//IEnumerable can be placed in a forEach loop

using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            
            IEnumerable<int> i1=arr;  //i1 points to the array that arr points

            //Cannot apply indexing with[] to an expression of type 'IEnumerable<int>'   
            //i1[2] = 3;  --> COMPILATION ERROR

            arr[2] = 9;

            //ToArray: Creates an array from a System.Collections.Generic.IEnumerable.
            //Returns:  An array that contains the elements from the input sequence.
            int[] arr1=i1.ToArray();
            int[] arr2 = arr;

            Console.WriteLine(arr == arr1);
            Console.WriteLine(arr==arr2);

            foreach (int item in i1)
            {
                Console.WriteLine(item);
            }



        }
    }
}



/*
 OUTPUT:
 _____________________
False
True
1
2
9
4
*/
