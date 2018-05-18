using System;

namespace _04_params
{
    class Program
    {

        static void PrintStudenmtsName1(string[] arr)
        {
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
        }


        static void PrintStudenmtsName2(params string[] arr)
        {
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("---------------PrintStudenmtsName1-------------------");
            PrintStudenmtsName1(new string[]{"Ori","Asa","Victoria","Tal","Marina"});

            Console.WriteLine("---------------PrintStudenmtsName2-------------------");
            PrintStudenmtsName2("Ori", "Asa", "Victoria", "Tal", "Marina");
        }
    }
}


/*
 output:

_______________________________________________________


---------------PrintStudenmtsName1-------------------
Ori
Asa
Victoria
Tal
Marina
---------------PrintStudenmtsName2-------------------
Ori
Asa
Victoria
Tal
Marina     
*/
