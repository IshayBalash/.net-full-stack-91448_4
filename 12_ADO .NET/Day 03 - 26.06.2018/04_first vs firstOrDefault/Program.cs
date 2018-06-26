using System.Linq;



/*
First
__________________________________________
Returns the first element of a sequence that satisfies a specified condition. (The first element in source that passes the test in predicate).
Does throw :System.InvalidOperationException:  No element satisfies the condition in predicate.-or-The source sequence is empty.
*/


/*
FirstOrDefault
__________________________________________
Returns the first element of a sequence that satisfies a specified condition
or a default value if no such element is found. (A function to test each element for a condition).
*/

namespace _03_single_table_in_ef
{
    class Program
    {
        static void Main(string[] args)
        {


            using(NorthwindEntities ef = new NorthwindEntities())
            {


                // we get an array with all the products with UnitPrice > 250
                Product[] prodArray1 = ef.Products.Where(p => p.UnitPrice > 250).ToArray();

                // we get the first product with UnitPrice > 250
                Product prod1 = ef.Products.FirstOrDefault(p => p.UnitPrice > 250);

                // we get the first product with UnitPrice > 250
                Product prod2 = ef.Products.First(p => p.UnitPrice > 250);




                // we get an empty array - because we dont have any product with UnitPrice > 265
                Product[] prodArray2 = ef.Products.Where(p => p.UnitPrice > 265).ToArray();

                // we get null (product is ref type - null is the default value) - because we dont have any product with UnitPrice > 265
                Product prod3 = ef.Products.FirstOrDefault(p => p.UnitPrice > 265);

                // we get Runtime error ("Sequence contains no elements") - because we dont have any product with UnitPrice > 265
                // Product prod4 = ef.Products.First(p => p.UnitPrice > 265);  //--> RUNTIME ERROR



                int[] numArray = { 1, 2, 3, 4 };

                //bigNum will get 0 (0 is default value for int type), because no element in the array is bigger than 10
                int bigNum = numArray.FirstOrDefault(n => n > 10);

            }
        }
    }
}


/*
OUTPUT:
_______________________________________


     
*/
