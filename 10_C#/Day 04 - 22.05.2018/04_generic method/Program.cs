using System;

namespace _04_generic_method
{
    class Program
    {

        static string Sub(string s1,string s2)
        {
            return s1 + s2;
        }


        static int Sub(int s1, int s2)
        {
            return s1 + s2;
        }


        static double Sub(double s1, double s2)
        {
            return s1 + s2;
        }


        static void Main(string[] args)
        {
            Console.WriteLine($"static string Sub(\"Bob\",\"Alice\") returned: {Sub("Bob", "Alice")} ");
            Console.WriteLine($"static int Sub(2,3) returned: {Sub(2,3)} ");
            Console.WriteLine($"static double Sub(3.25, 7.55) returned: {Sub(3.25, 7.55)} ");
        }
    }
}


/*
OUTPUT:
_____________________________

static string Sub("Bob","Alice") returned: BobAlice
static int Sub(2,3) returned: 5
static double Sub(3.25, 7.55) returned: 10.8
     
*/
