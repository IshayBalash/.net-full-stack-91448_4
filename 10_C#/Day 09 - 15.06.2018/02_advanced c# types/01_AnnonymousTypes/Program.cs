/*
 annonymous type כללים עבור הגדרת 
 _______________________________

 1. יש לאתחל עם ערך בשורת ההגדרה
 2.אם נרצה לקבל אפשרות לגשת למאפייני האובייקט בצורה נוחה דרך המצביע  var יש לבצע השמה רק למשתנה מסוג 
 3. אין לשנות ערך של מאפיין באובייקט אנונימי
 4. מותר לבצע למשתנה כולו השמה של אובייקט אנונימי חדש - החייב להיות מאותו מבנה שהאובייקט האנונימי הקודם הוגדר
 */

using System;

namespace Var
{
     class Example
    {
        public int Amount { get; set; }
        public string Message { get; set; }
    }

    class Program { 
    static void Main(string[] args)
    {


        var named = new Example() { Amount = 108, Message = "Hello" };
        var annonymous1 = new { Amount = 108, Message = "Hello" };
        var annonymous2 = new { Amount = 102, Message = "Hello2", Body = "hello" };
    
        Console.WriteLine("named.GetType(): "+named.GetType());
        Console.WriteLine("annonymous1.GetType(): "+annonymous1.GetType());
        Console.WriteLine("annonymous2.GetType(): "+annonymous2.GetType());

            /*
            '<anonymous type: int Amount, string Message>' 
            does not contain a definition for 'age' 
            and no extension method 'age' accepting a first 
            argument of type '<anonymous type: int Amount, string Message>' 
            could be found(are you missing a using directive or an assembly reference ?)	
            */
            //annonymous1.age = 100; //--> COMPILATION ERROR



  
            Console.WriteLine($"{annonymous1.Amount}  {annonymous1.Message}");


            /*
            Property or indexer '<anonymous type: int Amount, string Message>.Amount' 
            cannot be assigned to -- it is read only	
            */
            //annonymous1.Amount = 100;  //--> COMPILATION ERROR



            annonymous1 = new { Amount = 100, Message = "new Hello" };


            Console.WriteLine($"{annonymous1.Amount}  {annonymous1.Message}");

            /*
              Cannot implicitly convert 
              type '<anonymous type: int Amount, int Message>' 
              to '<anonymous type: int Amount, string Message>'    
            */
            //annonymous1 = new { Amount = 100, Message = 200};  //--> COMPILATION ERROR

        } }
}


/*
 OUTPUT
 ___________________________
named.GetType(): Var.Example
annonymous1.GetType(): <>f__AnonymousType0`2[System.Int32,System.String]
annonymous2.GetType(): <>f__AnonymousType1`3[System.Int32,System.String,System.String]
108  Hello
100  new Hello
     
*/
