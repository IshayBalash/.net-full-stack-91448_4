using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ref_param
{
    class Program
    {
        static void PrintArr(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        static void FindMinAndMax(int num1, int num2, int num3, ref int max, ref int min)
        {
            max = (num1 > num2 && num1 > num3) ? num1 : (num2 > num3) ? num2 : num3;

            min = (num1 < num2 && num1 < num3) ? num1 : (num2 < num3) ? num2 : num3;
        }

        static void UpdareArr(int[] arr)
        {
            arr[0] = 9;
        }

        static void InitArr(int[] arr)
        {
            arr = new int[] { 4,4 };
        }


        static void InitArrByRef(ref int[] arr)
        {
            arr = new int[] { 4, 4 };
        }

        static void Main(string[] args)
        {

            int num1 = 50, num2 = 17, num3 = 88, max=0, min=0;
            Console.WriteLine($"max: {max}, min: {min}");  //--> max: 0, min: 0
            FindMinAndMax(num1, num2, num3, ref max, ref min);
            Console.WriteLine($"max: {max}, min: {min}");  //--> max: 88, min: 17


            int[] arr = new int[] { 1, 2, 3 };

            PrintArr(arr);  //--> 1 2 3

            UpdareArr(arr);
            PrintArr(arr);  //--> 9 2 3

            InitArr(arr);
            PrintArr(arr);  //--> 9 2 3

            InitArrByRef(ref arr);
            PrintArr(arr);  //--> 4 4


        }


        
    }
}
