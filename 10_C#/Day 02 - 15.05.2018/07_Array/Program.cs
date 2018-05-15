using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Array
{
    class Program
    {
        static void Main(string[] args)
        {

  
            //משתנה רגיל -  value type
            //אסור להשתמש לפני שביצענו לתוכו השמה
            //איו לו ערך דיפולטיבי
            int simpleNum;
            //Console.WriteLine($"simpleNum is {simpleNum}");  //Use of unassigned local variable 'simpleNum' 



            //משתנה מצביע -  ref type
            // אחרי שהמשתנה מצביע לאובייקט אז לפני שביצענו למשתנים שבתוכו השמה
            //יהיה להם ערך דיפולטיבי
            /*
             bool --> false
             number (int or decimals) --> 0
             string --> null            
             */
            int[] numArray = new int[3];

            numArray[0] = 8;
            Console.WriteLine($"numArray[0] is { numArray[0]}");
            Console.WriteLine($"numArray[1] is { numArray[1]}");
            Console.WriteLine($"numArray[2] is { numArray[2]}");

            //numArray[8] = 3;  //--> System.IndexOutOfRangeException: Index was outside the bounds of the array.
        }
    }
}
