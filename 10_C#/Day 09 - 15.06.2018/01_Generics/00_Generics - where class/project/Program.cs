using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            SMS<string, DateTime> sms1;
            
            sms1= new SMS<string, DateTime>() {
                Subject = "Hi",
                Message = DateTime.Now,
                Addressee="Ishai"
        };

            
            sms1.Send("052-9856987");


            SMS<string, int> sms2;

            sms2 = new SMS<string, int>("Hello",6);

            sms2.Send("057-9857787");

            //The type 'int' must be a reference type 
            //in order to use it as parameter 'TSubject' 
            //in the generic type or method 'SMS<TSubject, TMessage>'

            // SMS<int, DateTime> sms3;  //--> COMPILATION ERROR
        }
    }
}



/*
 
     OUTPUT:
     ___________________
     
Sending Subject: Hi, Message: 15/06/2018 09:52:16 to 052-9856987
Sending Subject: Hello, Message: 6 to 057-9857787
*/
