using System;

namespace _06_out
{
    class Program
    {

        static void FilterArrayByEven(int[] src,out int[] target)
        {
            int oddCounter = 0;
            foreach (var item in src)
            {
                oddCounter += item%2;
            }

            target = new int[src.Length - oddCounter];

            int i = 0;
            foreach (var item in src)
            {
                if (item % 2==0)
                    target[i++] = item;
            }
        }

        static void Main(string[] args)
        {
            int[] numArray = new int[5];
            int[] evenNumFiltered;

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine($"please enter a number into elemnt {i+1}");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            FilterArrayByEven(numArray, out evenNumFiltered);

            foreach (int item in numArray)
            {
                Console.Write(item +", ");
            }

            Console.WriteLine();
            foreach (int item in evenNumFiltered)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}
