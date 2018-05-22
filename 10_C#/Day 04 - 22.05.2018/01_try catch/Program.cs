using System;

namespace _01_try_catch
{
    class Program
    {


        static int divNum()
        {
            int num1 = 9, num2=0, num3=0;

            try
            {
                num3 = num1 /num2;
                return num3;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return num3;
            }
           //the code in the "finally" block will run
           //alsoafter we had a "return" statment in the try / catch
            finally
            {
                //אין השפעה של השורה הזו על קידום הערך המוחזר
                //return כיוון שתוכן הערך המוחזר כבר נקבע למעלה בפקודת
                //finally ורק מתעכב עד שיסתיים ביצוע ה
                ++num3;
                Console.WriteLine("finally MSG");
            }

            Console.WriteLine("after all try & catch");
        }

        static void Main(string[] args)
        {

            int res = divNum();
            Console.WriteLine("divNum returned " +res);
        }
    }
}


/*
OUTPUT:
____________________________


Attempted to divide by zero.
finally MSG
divNum returned 0
Press any key to continue . . . 
 */
