using System;

namespace _06_generic_method
{
    class Program
    {

        static T ReturnMySelf<T>(T s1)
        {
            return s1;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine($"static string ReturnMySelf(\"Bob\") returned: {ReturnMySelf("Bob")} ");
            Console.WriteLine($"static int ReturnMySelf(2) returned: {ReturnMySelf(2)} ");
            Console.WriteLine($"static double ReturnMySelf(3.25) returned: {ReturnMySelf(3.25)} ");
        }
    }
}


/*
OUTPUT:
_____________________________

static string ReturnMySelf("Bob") returned: Bob
static int ReturnMySelf(2) returned: 2
static double ReturnMySelf(3.25) returned: 3.25
     
*/
