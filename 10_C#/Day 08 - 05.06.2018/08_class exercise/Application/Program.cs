using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc[] calcArray = {new Calc(),new Calc()};

            calcArray[0].CompareEventHandler += (num1, num2) => num1 > num2;

            calcArray[1].CompareEventHandler += (num1, num2) => num1 == num2;


            List<int[]> numberPairsArray = new List<int[]>();

            numberPairsArray.AddRange(new int[][]{
                new int[] { 1, 2 },
                new int[] { 1, 1 },
                new int[] { 5,8 },
                new int[] { 3,3 },
                new int[] { 2,7 },
                new int[] { 6,6 }
            } );

            foreach (int[] item in numberPairsArray)
            {
                foreach (Calc calc in calcArray)
                {
                    bool res=calc.TestNumbers(item[0], item[1]);
                    Console.WriteLine($"result of calc.TestNumbers({item[0]}, {item[1]}) is {res}");
                }
                Console.WriteLine("--------------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine($"calcArray[0] success counter {calcArray[0].SuccessCounter}");
            Console.WriteLine($"calcArray[1] success counter {calcArray[1].SuccessCounter}");

        }
    }
}


/*

OUTPUT
___________________________________

result of calc.TestNumbers(1, 2) is False
result of calc.TestNumbers(1, 2) is False
--------------------------------------
result of calc.TestNumbers(1, 1) is False
result of calc.TestNumbers(1, 1) is True
--------------------------------------
result of calc.TestNumbers(5, 8) is False
result of calc.TestNumbers(5, 8) is False
--------------------------------------
result of calc.TestNumbers(3, 3) is False
result of calc.TestNumbers(3, 3) is True
--------------------------------------
result of calc.TestNumbers(2, 7) is False
result of calc.TestNumbers(2, 7) is False
--------------------------------------
result of calc.TestNumbers(6, 6) is False
result of calc.TestNumbers(6, 6) is True
--------------------------------------

calcArray[0] success counter 0
calcArray[1] success counter 3
     
*/
