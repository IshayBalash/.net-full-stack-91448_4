using System;

namespace _11_var_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //מערך של אובייקטים אנונימיים
            //for "implicitly - typed array" we must to craete all the new{ } object with the same structer
              var list = new[]{
                new { Name="Alice", Age=13},
                new { Name="Alice", Age=14}
            };

            foreach (var item in list)
            {
                Console.WriteLine(item.Name+ " "+item.Age);
            };


            object[] list1 = new[]{
                new { Name="Alice", Age=13},
                new { Name="Alice", Age=14}
            };

            foreach (var item in list1)
            {
                //Console.WriteLine(item.Name + " " + item.Age);  // --> COMPILATION ERROR
            }
        }
    }
}
