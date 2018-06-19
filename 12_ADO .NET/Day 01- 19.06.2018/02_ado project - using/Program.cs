//ActiveX Data Objects (ADO)

using System;
using System.Data.SqlClient;

namespace _02_ado_project
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string connectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True"; 
            SqlConnection sql=null;


            try
            {
                using (sql = new SqlConnection(connectionString))
                {

                    sql.Open();

                    SqlCommand query = new SqlCommand("SELECT ProductName FROM Products WHERE ProductId=1", sql);

                    object result = query.ExecuteScalar();

                    Console.WriteLine($"ProductName with id 1 is: {result}");

                    Console.WriteLine("inside using:"+((sql != null) ? sql.State.ToString() : "sql object is null"));

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("after using:" + ((sql != null) ? sql.State.ToString() : "sql object is null"));



        }
    }
}


/*
 OUTPUT:
 _______________________

ProductName with id 1 is: Chai
inside using:Open
after using:Closed
*/
