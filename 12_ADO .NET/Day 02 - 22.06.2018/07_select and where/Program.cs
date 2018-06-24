using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_select_and_where
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };

            //פילטור המערך למספרים זוגיים בלבד
            IEnumerable<int> res1 = list.Where((int i) => { return i % 2 == 0; });

            Console.WriteLine("res1--------------------");
            foreach (int item in res1)
            {
                Console.WriteLine(item);
            }


            //הצגת הריבוע של כל מספר במערך
            IEnumerable<int> res2 = list.Select((int i) => { return i * i; });

            Console.WriteLine("res2--------------------");
            foreach (int item in res2)
            {
                Console.WriteLine(item);
            }



            //הצגת הריבוע של כל מספר זוגי במערך
            IEnumerable<int> res3 = list
                .Where((int i) => { return i % 2 == 0; })
                .Select((int i) => { return i * i; });

            Console.WriteLine("res3--------------------");
            foreach (int item in res3)
            {
                Console.WriteLine(item);
            }


            //הצגת הריבוע של כל מספר במערך
            IEnumerable<string> res4 = list.Select((int i) => { return $"number is {i}"; });

            Console.WriteLine("res4--------------------");
            foreach (string item in res4)
            {
                Console.WriteLine(item);
            }
        }
    }
}


/*
 OUTPUT:
 ________________
res1--------------------
2
4
6

res2--------------------
1
4
9
16
25
36

res3--------------------
4
16
36

res4--------------------
number is 1
number is 2
number is 3
number is 4
number is 5
number is 6
*/
