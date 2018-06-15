using System;

namespace Generics
{
    /// <summary>
    /// SMS is a class that represents the full info of a ama msg
    /// </summary>
    /// <typeparam name="TSubject"></typeparam>
    /// <typeparam name="TMessage"></typeparam>
    
    public class SMS<TSubject, TMessage> 
     where TSubject : class 
     where TMessage : struct
    {
        public string Addressee { get; set; }
        public TSubject Subject { get; set; } 
        public TMessage Message { get; set; }

        public SMS(){}

        public SMS(TSubject subject, TMessage message, string addressee = null)
        {
            Addressee = addressee;
            Subject = subject;
            Message = message;
        }

        public void Send(string phone)
        {
            Console.WriteLine($"Sending Subject: {Subject}, Message: {Message} to {phone}");
        }
    }
}
