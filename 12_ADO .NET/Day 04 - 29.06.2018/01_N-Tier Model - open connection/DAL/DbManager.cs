using BOL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


// DAL = Data Access Layer
namespace DAL
{
    public static class DbManager
    {
        private static string GetSqlConnection()
        {
            string str = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("\\bin\\Debug", "").Replace("file:\\", "");
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + str + "\\FoodDb.mdf\";Integrated Security=True";

            return connectionString;
        }


        public static List<FoodSearchData> GetDbResults()
        {

            List<FoodSearchData> resList = new List<FoodSearchData>();

            try
            {
                using (SqlConnection sql = new SqlConnection(GetSqlConnection()))
                {

                    sql.Open();

                    SqlCommand query = new SqlCommand("SELECT FoodName,Price,IsVeg,SearchQuery FROM [dbo].[FoodRes] AS f JOIN [dbo].[FoodSearch] AS s ON f.SearchId=s.SearchId", sql);
                    SqlDataReader reader = query.ExecuteReader();


                    while (reader.Read())
                    {
                        resList.Add(new FoodSearchData
                        {
                            FoodName = reader[0].ToString(),
                            Price = (int)reader[1],
                            IsVeg = (bool)reader[2],
                            SearchQuery = reader[3].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return resList;
        }


        public static int UpdateDbResults(int searchId, Food food)
        {
            int res = 0;
                try
            {
                using (SqlConnection sql = new SqlConnection(GetSqlConnection()))
                {

                    sql.Open();
                    byte isVeg = (byte)((food.IsVeg) ? 1 : 0);
                    SqlCommand query = new SqlCommand($"INSERT INTO [dbo].[FoodRes] ([FoodName],[Price],[IsVeg],[SearchId]) VALUES ('{food.FoodName}',{food.Price},{isVeg},{searchId}) ", sql);

                    res=query.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return res;

        }


        public static int UpdateDbSearch(string searchQuery)
        {
            int searchId = 0;
               try
            {
                using (SqlConnection sql = new SqlConnection(GetSqlConnection()))
                {

                    sql.Open();

                    SqlCommand query = new SqlCommand($"INSERT INTO [dbo].[FoodSearch] ([SearchQuery]) VALUES ('{searchQuery}') ", sql);

                    query.ExecuteNonQuery();

                    query = new SqlCommand($"SELECT TOP 1 [SearchId] FROM [dbo].[FoodSearch] ORDER BY [SearchId] DESC", sql);

                    object res = query.ExecuteScalar();

                    searchId = (int)res;


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
