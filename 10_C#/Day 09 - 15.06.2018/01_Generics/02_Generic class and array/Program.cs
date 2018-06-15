namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            ISend[] arr = {
                new SMS<string, int> {Subject="msg1",Message= 2,Addressee="05448988888" },
                new SMS<string, bool> { Subject="msg2",Message= true,Addressee="05448966688"},
                new MMS<string, double,string> { Subject="msg3",Message= 2.4, ImageMsg="img.png",Addressee="0544888888"}
            };

            foreach (ISend item in arr)
            {
                item.Send(item.Addressee);
            }

        }
    }
}


/*
OUTPUT:
________________________________________
     
Sending Subject: msg1, Message: 2 to 05448988888
Sending Subject: msg2, Message: True to 05448966688
Sending Subject: msg3, Message: 2.4 to 0544888888
*/
