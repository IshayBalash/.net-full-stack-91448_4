using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_collections
{
    class Program
    {

        static void PrintList(string arrayName,List<string> collection)
        {

      
            Console.WriteLine($"{arrayName} Capacity: {collection.Capacity}");
            foreach (string str in collection)
            {
                Console.Write(str+" ,");
            }
            Console.WriteLine();

        }

        static void Main(string[] args)
        {

            //---------------------------מערך רגיל - בעל אורך קבוע-------------------------
            string[] names1 = { "A", "B", "C" };
            PrintList("names1",names1.ToList());  //List המרה ממערך ל

            //System.IndexOutOfRangeException:
            //names1[3] = "D";  --> runtime Exception

            //---------------------------מערך דינמי - בעל אורך משתנה-------------------------
            List <string> names2 = new List<string>();  //we can send to the constructor of "List" capacity

            

            names2.AddRange(names1);


            names2.Add("D");
            PrintList("names2",names2);

            names2.Add("F");
            PrintList("names2", names2);

            names2.AddRange(names1);
            PrintList("names2", names2);

            names2.RemoveAt(2);
            PrintList("names2", names2);

            string str = names2[names2.Count / 2];
            names2.Remove(str);
            PrintList("names2", names2);


        }
    }
}
