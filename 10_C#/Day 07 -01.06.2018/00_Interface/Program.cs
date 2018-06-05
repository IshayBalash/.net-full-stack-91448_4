using System.Collections.Generic;
using System.Windows.Forms;

namespace _00_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //בתוך מערך של ממשק - נוכל להכניס לכל תא מופע של מחלקה שמממשת את הממשק הזה
            Queue<IPayRent> payQueue = new Queue<IPayRent>();

            //-----------------------------------------------------

            //דרך ארוכה לאיתחול משתנים של המופע
            BikeRent bikeRent = new BikeRent();

            bikeRent.RentAmount = 200;
            bikeRent.HourAmount = 4;

            payQueue.Enqueue(bikeRent);

            //דרך קצרה לאיתחול משתנים של המופע
            bikeRent = new BikeRent { HourAmount=3,RentAmount=150};

            payQueue.Enqueue(bikeRent);

            //-----------------------------------------------------
            
            Address address = new Address("USA", "Cambridge") { Street = "Massachusetts Avenue", HouseNumber = 77 };
            payQueue.Enqueue(new University { UniversityName="MIT", RentAmount=20000,  HouseAddress= address });
            payQueue.Enqueue(new Shop { ShopName = "Zara", ShopCategory = Category.Cloth, HouseAddress = new Address("Israel","TLV") });


            for (int i = 0; i < payQueue.Count; )
            {
                //ביצוע תשלום - בצורה גנרית - בזכות הממשק שמהווה בסיס לכל המחלקות של המופעים בתור
                payQueue.Peek().PayRent(2000);

                //הסרת אלמנט מהתור
                MessageBox.Show(getPaymentType(payQueue.Dequeue()));
            }
          

        }

        static string getPaymentType(IPayRent payRent)
        {
            // BikeRent  בדיקה האם האובייקט בזיכרון הוא מטיפוס 
            // "is" - returns a boolean value - if the object is instance of the current class or not
            if (payRent is BikeRent)
            {
                // המרה מפורשת
                return $"BikeRent: for {((BikeRent)payRent).HourAmount} hours";
            }


            // HouseInfo  בשלב זה ננסה לבצע המרה לטיפוס 
            // "as" - converts the instance to the givven "houseInfo" var
            // if the instance is not a type of "HouseInfo" - "houseInfo" will get null
            HouseInfo houseInfo = payRent as HouseInfo;
            if (houseInfo!=null)
            {
                string houseDescription = (houseInfo is University) ? "University" : "shop";
                return $"{houseDescription} House Address {houseInfo.HouseAddress}";
            }

            return null;
        }
    }
}



/*
 
OUTPUT:
__________________________________

BikeRent: for 4 hours
BikeRent: for 3 hours
University House Address 77 Massachusetts Avenue st. / Cambridge / USA
shop House Address 0  st. / TLV / Israel   
     
*/
