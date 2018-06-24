using System;
using System.Collections.Generic;
using System.Linq;

//LINQ  =  Language-Integrated Query  (CAN RUN ON C# IEnumerable OBJECTS)
namespace _04_Basic_LINQ
{
    class Product
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            {

                List <Product> srcList = new List<Product>
            {
                new Product {ProductName="Pizza",UnitPrice=20 },
                new Product {ProductName="Chips",UnitPrice=12 },
                new Product {ProductName="Water",UnitPrice= 6},
                new Product {ProductName="Burger",UnitPrice=50 },
                new Product {ProductName="HotDog",UnitPrice=14 }
            };

            //בחירת כל המוצרים שמחירם גדול מ15
            IEnumerable<Product> distList1 = srcList.Where((Product prod) => { return prod.UnitPrice > 15; });


            foreach (Product item in distList1)
            {
                Console.WriteLine($"ProductName:{item.ProductName}  , UnitPrice:{item.UnitPrice}");
            }


                //בחירת שמות כל המוצרים שמחירם גדול מ15
                IEnumerable<string> distList2 = srcList
                    .Where((Product prod) => { return prod.UnitPrice > 15;})
                    .Select((Product prod) => { return prod.ProductName; });


            foreach (string item in distList2)
            {
                Console.WriteLine($"ProductName:{item}");
            }

        }
    }
}

/*
OUTPUT:
______________________________

ProductName:Pizza  , UnitPrice:20
ProductName:Burger  , UnitPrice:50

ProductName:Pizza
ProductName:Burger
     
*/
