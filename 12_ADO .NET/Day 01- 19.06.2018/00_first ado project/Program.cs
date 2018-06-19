using System.Data.SqlClient;

namespace _00_first_ado_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 1: declare the connection string
            string connectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";


            //step 2: declare the SqlConnection with the ConnectionString from step 1
            SqlConnection sql = new SqlConnection(connectionString);


            //step 3: Opens a database connection with the SqlConnection from step 2
            sql.Open();


            //step 4: Initializes a new instance of SqlCommand  with the text of the query and the SqlConnection from step 2
            SqlCommand query = new SqlCommand("SELECT ProductName FROM Products WHERE ProductId=1", sql);


            //step 5: Executes the query, and returns the first column of the first row in the result
            object result=query.ExecuteScalar();


            //step 6: Closes the connection to the database. 
            sql.Close();

            System.Console.WriteLine($"ProductName with id 1 is: {result}");


        }
    }
}


/*
 OUTPUT:
 _______________________
 ProductName with id 1 is: Chai

*/
