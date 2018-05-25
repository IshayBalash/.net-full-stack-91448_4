using System;

namespace _06_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            WeekendHobies myWeekendHobies = WeekendHobies.Learning;
            Console.WriteLine($"this weekend I am planning {myWeekendHobies} and {WeekendHobies.Coding}");
        }
    }
}


/*
OUTPUT:
_____________________________________

this weekend I am planning Learning and Coding    
*/
