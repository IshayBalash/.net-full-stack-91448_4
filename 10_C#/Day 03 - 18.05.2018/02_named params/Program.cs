using System;

namespace _02_named_params
{
    class Program
    {

        static int divNum(int numInt)  //F1 סימן זיהוי לפונקציה 
        {
            return numInt / 2;
        }

        static double divNum(double numDouble)  //F2 סימן זיהוי לפונקציה 
        {
            return numDouble / 2;
        }

        static void Main(string[] args)
        {

            double res;

            res = divNum(3); // F1  תתבצע קריאה ל
            Console.WriteLine($"{res}");  //--> 1

            res = divNum(3.0); // F2  תתבצע קריאה ל
            Console.WriteLine($"{res}");  //--> 1.5

            int myNumber = 7;

            res = divNum(myNumber); // F1  תתבצע קריאה ל
            Console.WriteLine($"{res}");  //--> 3

            // first option to call F2 with int param : cast int to double

            res = divNum((double)myNumber); // F2 תתבצע קריאה ל
            Console.WriteLine($"{res}");  //--> 3.5

            // second option to call F2 with int param : named parameters

            res = divNum(numDouble:myNumber); // F2 תתבצע קריאה ל
            Console.WriteLine($"{res}");  //--> 3.5

        }
    }
}
