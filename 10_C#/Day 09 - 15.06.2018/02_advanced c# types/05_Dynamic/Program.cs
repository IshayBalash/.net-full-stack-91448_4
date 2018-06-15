using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            dynamic test = 1;
            Console.WriteLine($"{test}, {test.GetType()}");


            test = new int[]{1,2,3,4};
            Console.WriteLine($"{test}, {test.GetType()}");


            test ="My String";
            Console.WriteLine($"{test}, {test.GetType()}");


            test = new { Name="Alice",Age=20};
            Console.WriteLine($"{test}, {test.GetType()}");
        }
    }
}


/*
OUTPUT:
___________________________

1, System.Int32
System.Int32[], System.Int32[]
My String, System.String
{ Name = Alice, Age = 20 }, <>f__AnonymousType0`2[System.String,System.Int32] 
*/
