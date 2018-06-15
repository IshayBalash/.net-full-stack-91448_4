using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = null;  //--> compilation error
            int? num2 = null;
            Nullable<int> num3 = null;  // same as int? num3 


            // The HasValue property is true if num2 != null
            if (num2.HasValue)
            {
                Console.WriteLine("num = " + num2.Value);
                Console.WriteLine("num = " + num2);
            }
            else
            {
                Console.WriteLine("num = Null");
                //Console.WriteLine("num = " + num2.Value);  // --> System.InvalidOperationException: Nullable object must have a value.
            }

          
            num2=num2 ?? 5;  // is :   num2 = (num2 == null) ? 5 : num2;

            Console.WriteLine(num2);

            num2 = 0;
            num2 = num2 ?? 5;
            Console.WriteLine(num2);

        }
    }
}


/*
 
OUTPUT:
___________________________
num = Null
5
0
*/
