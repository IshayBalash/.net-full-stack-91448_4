using System;

namespace _09_var_vs_object
{

    class Program
    {
        static void Main(string[] args)
        {

            object obj1 = new { Age = 22, Name = "Tom" };  //object can not access the "Age" and "Name" properties

            var obj2 = new { Age = 22, Name = "Tom" };  //var can access the "Age" and "Name" properties


            /*
             'object' does not contain a definition for 'Age' 
              and no extension method 'Age' accepting a first argument of type 'object' could be found
             (are you missing a using directive or an assembly reference ?)
           */
            //Console.WriteLine(obj1.Age); --> compilation error

            Console.WriteLine(obj2.Age); 
        }
    }
}

