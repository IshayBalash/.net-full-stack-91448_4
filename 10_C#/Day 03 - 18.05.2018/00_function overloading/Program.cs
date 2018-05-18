using System;

/*
 העמסת פונקציות  - function overloading
_________________________________________________

1. כל הפונקציות חייבות להיות בעלות אותו שם
2. כל פונקציה חייבת לקבל מספר פרמטרים שונה או אותו מספר פרמטרים אבל טיפוסי פרמטרים שונים
3. ערך מוחזר מטיפוס שונה - לא עומד בתנאי ההעמסה
4. שמות פרמטרים שונים - לא משפיעים על ההעמסה   
     */
namespace _00_function_overloading
{
    class Program
    {
        static int GetAvg(int param1, int param2)
        {
            return (param1 + param2) / 2;
        }


        static decimal GetAvg(decimal param1, decimal param2)
        {
            return (param1 + param2) / 2;
        }

        static void Main(string[] args)
        {
            int grade1 = 100, grade2 = 95;
            decimal waterPrice1 = 12.5M, waterPrice2 = 7;

            decimal gradeAvg = GetAvg(grade1, grade2);  //המרה מרומזת - כי אין סכנה לאיבוד מידע

            decimal priceAvg = GetAvg(waterPrice1, waterPrice2);

            Console.WriteLine($" grade1 is {grade1}\n grade2 is {grade2}");
            Console.WriteLine($" avg of grade1 & grade2 is {(grade1+grade2)/2}");
            Console.WriteLine($" avg of grade1 & grade2 is {(grade1 + grade2) / 2.0}");
            Console.WriteLine($" avg of grade1 & grade2 is {gradeAvg}");

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine($" waterPrice1 is {waterPrice1}\n waterPrice2 is {waterPrice2}");
            Console.WriteLine($" avg of waterPrice1 & waterPrice2 is {(waterPrice1 + waterPrice2) / 2}");
            Console.WriteLine($" avg of waterPrice1 & waterPrice2 is {priceAvg}");
        }
    }
}


/*
 output:

__________________________________________

 grade1 is 100
 grade2 is 95
 avg of grade1 & grade2 is 97
 avg of grade1 & grade2 is 97.5
 avg of grade1 & grade2 is 97
---------------------------------------------
 waterPrice1 is 12.5
 waterPrice2 is 7
 avg of waterPrice1 & waterPrice2 is 9.75
 avg of waterPrice1 & waterPrice2 is 9.75
*/
