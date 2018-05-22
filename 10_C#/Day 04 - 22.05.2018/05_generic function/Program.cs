using System;

namespace _05_generic_method
{
    class Program
    {

        static void ShowParam<T,K>(T param1,K param2)
        {
            Console.WriteLine($"param1: {param1}, param2: {param2}");
        }

        static  void NonReturnedVal<T>()
        {
            return;
        }

        static void Main(string[] args)
        {
            ShowParam("Bob", "Alice");
            ShowParam("Bob", 3);
            ShowParam(true, 4.88);
            ShowParam(9, false);

            NonReturnedVal<int>( );
        }
    }
}


/*
OUTPUT:
_____________________________

param1: Bob, param2: Alice
param1: Bob, param2: 3
param1: True, param2: 4.88
param1: 9, param2: False
     
*/
