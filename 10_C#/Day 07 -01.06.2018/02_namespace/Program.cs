using _02_namespace_v2;
using _02_namespace_v4;

namespace _02_namespace_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            //למרות שהוספנו בדף למעלה את החלקים הבאים:
            //using _02_namespace_v2;
            //using _02_namespace_v4;
            // Color  נקבל שגיאת קומפילציה כי 
            //namespaceמופיע בשתי ה
            //'Color' is an ambiguous reference between '_02_namespace_v2.Color' and '_02_namespace_v4.Color' 

            //Color color;  -->COMPILATION ERROR


            _02_namespace_v4.Color color1 = new _02_namespace_v4.Color { Red=255,Green=0,Blue=0};
            _02_namespace_v2.Color color2 = _02_namespace_v2.Color.Blue;

            System.Console.WriteLine($"{color1.Red},{color1.Green},{color1.Blue},{color2}");

        }
    }
}
