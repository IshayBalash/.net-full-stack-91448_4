using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_fk_in_table
{
    class Program
    {
        static void Main(string[] args)
        {

            //every category is refered by few Products (fk - one(Category) to many(Product) ) 

            using(NorthwindEntities ef=new NorthwindEntities())
            {
                foreach(Category c in ef.Categories)
                {
                    Console.WriteLine($"{c.CategoryName} owns products (UnitPrice<15) :");
                    foreach (Product p in c.Products.Where(p=>p.UnitPrice<20))
                    {
                        Console.Write($"{p.ProductName}, ");
                    }
                    Console.WriteLine("\n_____________________________________________________________");
                }
            }
        }
    }
}


/*
OUTPUT:
_____________________________________________________________


Beverages owns products (UnitPrice<15) :
Chai, Chang, Guaraná Fantástica, Sasquatch Ale, Steeleye Stout
_____________________________________________________________
Condiments owns products (UnitPrice<15) :
Aniseed Syrup, Genen Shouyu, Gula Malacca
_____________________________________________________________
Confections owns products (UnitPrice<15) :
Pavlova, Teatime Chocolate Biscuits, Sir Rodney's Scones
_____________________________________________________________    
*/
