using System;

namespace _00_ef
{
    class Program
    {
        static void Main(string[] args)
        {


            using (NorthwindEntities ef=new NorthwindEntities())
            {

                foreach (Category item in ef.Categories)
                {
                    Console.WriteLine(item.CategoryName);
                }
                
            }
        }
    }
}


/*
OUTPUT:
_______________________

Beverages
Condiments
Confections
Dairy Products
Grains/Cereals
Meat/Poultry
Produce
Seafood
 
*/
