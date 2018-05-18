using System;

namespace _08_check_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
 
            // Converts the string representation of a number to its 32 - bit signed integer equivalent.
            //     A return value indicates whether the conversion succeeded.
            //
            // Parameters:
            //   s: A string containing a number to convert.
            //   num: Out parameter - will get the converted number - if the conversion succeeded, or zero if the conversion failed
            //
            // Returns:
            //     true if s was converted successfully; otherwise, false.
            bool isConvertSuccess = int.TryParse("12",out num);
            Console.WriteLine($"int.TryParse(\"12\",out num) gives:" );
            Console.WriteLine($"isConvertSuccess ={ isConvertSuccess}, num ={num}");
            Console.WriteLine();

            isConvertSuccess = int.TryParse("Alice", out num);
            Console.WriteLine($"int.TryParse(\"Alice\",out num) gives:");
            Console.WriteLine($"isConvertSuccess ={ isConvertSuccess}, num ={num}");
        }
    }
}


/*
output:
______________________________

int.TryParse("12",out num) gives:
isConvertSuccess =True, num =12

int.TryParse("Alice",out num) gives:
isConvertSuccess =False, num =0
*/
