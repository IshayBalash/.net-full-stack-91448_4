using System.Linq;


namespace _05_crud_in_ef
{
    class Program
    {
        static void Main(string[] args)
        {

            using(NorthwindEntities ef = new NorthwindEntities())
            {

                /***********************CREATE***********************/
                // craete a new produc
                Product newProd = new Product { ProductName= "Computer", UnitPrice=9000, CategoryID=4, UnitsOnOrder=9, Discontinued=true, SupplierID=1, UnitsInStock=9, ReorderLevel=2, QuantityPerUnit="1 in box"};

                //add the new product to the table (is saved only in local copy)
                ef.Products.Add(newProd);


                /***********************READ***********************/
                // we get all products with UnitPrice > 100
                Product[] prod = ef.Products.Where(p => p.UnitPrice > 100).ToArray();


                /***********************UPDATE***********************/
                if (prod.Length>0)
                    //update only the first element in the products array to UnitPrice = 250 (is saved only in local copy)
                    prod[0].UnitPrice = 250;


                /***********************DELETE***********************/
                Product prodToRemove = prod.FirstOrDefault(p => p.ProductName == "Phone");
                if (prodToRemove!=null)
                    //remove only the second element in the products array (is saved only in local copy)
                    ef.Products.Remove(prodToRemove);
                
         
                //save all the local changes to the DB
                ef.SaveChanges();


            }
        }
    }
}


/*
OUTPUT:
_______________________________________

     
*/
