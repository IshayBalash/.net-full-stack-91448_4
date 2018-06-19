using System;
using System.Data.SqlClient;

namespace _05_ado_project
{

    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection sql = null;

            try
            {
                using (sql = new SqlConnection(connectionString))
                {

                    sql.Open();
               
                    int minPrice, maxPrice;

                    Console.WriteLine("Please enter min price:");
                    int.TryParse(Console.ReadLine(),out minPrice);


                    Console.WriteLine("Please enter max price:");
                    int.TryParse(Console.ReadLine(), out maxPrice);

                    SqlCommand query = new SqlCommand($"SELECT [ProductName], [UnitPrice] FROM [dbo].[Products] WHERE [UnitPrice] BETWEEN {minPrice} AND {maxPrice}", sql);

                    // Sends the CommandText to Sql Connection and builds a SqlDataReader.
                    SqlDataReader dataReader = query.ExecuteReader();

                    //Read() - Advances the SqlDataReader to the next record. Returns true if there are more rows; otherwise false.
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"{dataReader[0]} costs {(decimal)dataReader[1]}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}




/*
 OUTPUT:
 _______________________

Please enter min price:
2
Please enter max price:
10

Aniseed Syrup costs 10.0000
Konbu costs 6.0000
Teatime Chocolate Biscuits costs 9.2000
Sir Rodney's Scones costs 10.0000
Tunnbr?d costs 9.0000
Guaraná Fantástica costs 4.5000
Geitost costs 2.5000
Jack's New England Clam Chowder costs 9.6500
Rogede sild costs 9.5000
Zaanse koeken costs 9.5000
Filo Mix costs 7.0000
Tourti?re costs 7.4500
Longlife Tofu costs 10.0000
Rh?nbr?u Klosterbier costs 7.7500
*/
