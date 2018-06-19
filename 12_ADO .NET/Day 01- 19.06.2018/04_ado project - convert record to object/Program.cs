using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _04_ado_project
{
    
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection sql = null;

            List<Category> categoryList = new List<Category>();

            try
            {
                using (sql = new SqlConnection(connectionString))
                {

                    sql.Open();

                    SqlCommand query = new SqlCommand("SELECT * FROM [dbo].[Categories]", sql);

                    // Sends the CommandText to Sql Connection and builds a SqlDataReader.
                    SqlDataReader dataReader = query.ExecuteReader();

                    //Read() - Advances the SqlDataReader to the next record. Returns true if there are more rows; otherwise false.
                    while (dataReader.Read())
                    {
                        categoryList.Add(new Category(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2)));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (Category item in categoryList)
            {
                Console.WriteLine(item);
            }
        }
    }
}




/*
 OUTPUT:
 _______________________

CategoryId: 1, CategoryName: Beverages, Description: Soft drinks, coffees, teas, beers, and ales
CategoryId: 2, CategoryName: Condiments, Description: Sweet and savory sauces, relishes, spreads, and seasonings
CategoryId: 3, CategoryName: Confections, Description: Desserts, candies, and sweet breads
CategoryId: 4, CategoryName: Dairy Products, Description: Cheeses
CategoryId: 5, CategoryName: Grains/Cereals, Description: Breads, crackers, pasta, and cereal
CategoryId: 6, CategoryName: Meat/Poultry, Description: Prepared meats
CategoryId: 7, CategoryName: Produce, Description: Dried fruit and bean curd
CategoryId: 8, CategoryName: Seafood, Description: Seaweed and fish
CategoryId: 9, CategoryName: Tech, Description: The real life
CategoryId: 10, CategoryName: Tech, Description: Computers and more
*/
