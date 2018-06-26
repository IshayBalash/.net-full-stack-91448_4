
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ef
{
    class Program
    {
        static void Main(string[] args)
        {
            using(NorthwindEntities ef=new NorthwindEntities())
            {
                IEnumerable<string> arr1 = ef.Customers
                                                .Where((Customer c) => c.CompanyName.StartsWith("A"))
                                                .Select((Customer c) => c.CompanyName);

                Console.WriteLine("----------------------arr1--------------------");
                foreach (string item in arr1)
                {
                    Console.WriteLine(item);
                }



                IEnumerable<string> arr2 = from c in ef.Customers
                                           where c.CompanyName.StartsWith("A")
                                           select c.CompanyName;
                
                Console.WriteLine("----------------------arr2--------------------");
                foreach (string item in arr2)
                {
                    Console.WriteLine(item);
                }


            }
        }
    }
}


/*
 OUTPUT:
 ________________________

 ----------------------arr1--------------------
Alfreds Futterkiste
Ana Trujillo Emparedados y helados
Antonio Moreno Taquería
Around the Horn
----------------------arr2--------------------
Alfreds Futterkiste
Ana Trujillo Emparedados y helados
Antonio Moreno Taquería
Around the Horn

 */
