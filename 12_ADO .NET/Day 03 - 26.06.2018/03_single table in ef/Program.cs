using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_single_table_in_ef
{
    class Program
    {
        static void Main(string[] args)
        {


            using(NorthwindEntities ef = new NorthwindEntities())
            {
                IEnumerable<Product> productList= ef.Products.Where(p => p.UnitPrice > 10 && p.UnitPrice < 13);

                foreach (Product item in productList)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}


/*
OUTPUT:
_______________________________________

ProductID: 31,ProductName Gorgonzola Telino, SupplierID 14 ,CategoryID 4,  UnitPrice 12.5000
ProductID: 46,ProductName Spegesild, SupplierID 21 ,CategoryID 8,  UnitPrice 12.0000
ProductID: 48,ProductName Chocolade, SupplierID 22 ,CategoryID 3,  UnitPrice 12.7500
ProductID: 68,ProductName Scottish Longbreads, SupplierID 8 ,CategoryID 3,  UnitPrice 12.5000     
     
*/
