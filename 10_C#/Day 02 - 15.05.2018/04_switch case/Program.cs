using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {

            int temp = 19;

            //הערה חשובה
            //חובה לשים את המילה
            //brak / return
            //case אחרי כל 
            // brak / return ריק אפשר לוותר על case אבל אם נשאיר
            //אם יש אחריו אופציה נוספת - והיא זו שתתרחש עבורו
            switch (temp)
            {
                case 16: Console.WriteLine("please turn the heater on"); break;
                case 18:
                case 19:
                case 20: 
                case 21:
                case 22:
                case 23: Console.WriteLine("please turn the heater off"); break;

                default: Console.WriteLine("Do not touch the heater"); break;
            }
        }
    }
}
