using System;
using System.Data.SqlClient;

namespace _00_update_while_action__with_event_
{
    static class DbManager
    {


        public static void ShowDbResults()
        {
            string str = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("\\bin\\Debug", "").Replace("file:\\", "");
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + str + "\\FoodDb.mdf\";Integrated Security=True";
            try
            {
                using (SqlConnection sql = new SqlConnection(connectionString))
                {

                    sql.Open();
                  
                    SqlCommand query = new SqlCommand("SELECT FoodName,Price,IsVeg,SearchQuery FROM [dbo].[FoodRes] AS f JOIN [dbo].[FoodSearch] AS s ON f.SearchId=s.SearchId", sql);
                    SqlDataReader reader= query.ExecuteReader();


                    while (reader.Read())
                    {
                        Console.WriteLine($"FoodName: {reader[0]}, Price: {reader[1]}, IsVeg: {reader[2]}, SearchQuery: {reader[3]} ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void UpdateDbResults(int searchId,Food food)
        {
            string str = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("\\bin\\Debug", "").Replace("file:\\", "");
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + str + "\\FoodDb.mdf\";Integrated Security=True";
            try
            {
                using (SqlConnection sql = new SqlConnection(connectionString))
                {

                    sql.Open();
                    byte isVeg = (byte)((food.IsVeg) ? 1 : 0);
                    SqlCommand query = new SqlCommand($"INSERT INTO [dbo].[FoodRes] ([FoodName],[Price],[IsVeg],[SearchId]) VALUES ('{food.FoodName}',{food.Price},{isVeg},{searchId}) ", sql);

                    query.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
        }

    public static int UpdateDbSearch(string searchQuery)
        {
            int searchId = 0;
            string str = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("\\bin\\Debug", "").Replace("file:\\","");
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + str + "\\FoodDb.mdf\";Integrated Security=True";
            try
            {
                using (SqlConnection sql = new SqlConnection(connectionString))
                {

                    sql.Open();

                    SqlCommand query = new SqlCommand($"INSERT INTO [dbo].[FoodSearch] ([SearchQuery]) VALUES ('{searchQuery}') ", sql);

                    query.ExecuteNonQuery();

                    query = new SqlCommand($"SELECT TOP 1 [SearchId] FROM [dbo].[FoodSearch] ORDER BY [SearchId] DESC", sql);

                    object res=query.ExecuteScalar();

                    searchId=(int)res;


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return searchId;

        }
    }
}
