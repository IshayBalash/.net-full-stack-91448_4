using System;

namespace Generics
{
    public class SMS<TSubject, TMessage> : ISend
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
