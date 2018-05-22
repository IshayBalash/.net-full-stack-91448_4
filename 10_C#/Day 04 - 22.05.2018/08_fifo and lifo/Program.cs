using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_fifo_and_lifo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---------------------------Queue------------------");

            Queue <string> names1 = new Queue<string>();  //FIFO -> First In First Out
            names1.Enqueue("A1");
            names1.Enqueue("A2");
            names1.Enqueue("A3");
            names1.Enqueue("A4");
            foreach (string item in names1)
            {
                Console.Write(item + " ,");
            }

            Console.WriteLine();


            string str1 = names1.Dequeue();  
            Console.WriteLine($"\nnames1 is serving now element {str1}");

            foreach (string item in names1)
            {
                Console.Write(item + " ,");
            }
            str1 = names1.Peek();
            Console.WriteLine($"\nnames1 will serve soon element {str1}");
            Console.WriteLine("after peek:");
            foreach (string item in names1)
            {
                Console.Write(item + " ,");
            }


            Console.WriteLine("\n---------------------------Stack------------------");

            Stack<string> names2= new Stack<string>();  //LIFO -> Last In First Out
            names2.Push("A1");
            names2.Push("A2");
            names2.Push("A3");
            names2.Push("A4");
            foreach (string item in names2)
            {
                Console.Write(item + " ,");
            }

            Console.WriteLine();


            string str2 = names2.Pop();
            Console.WriteLine($"\nnames2 is serving now element {str2}");

            foreach (string item in names2)
            {
                Console.Write(item + " ,");
            }
            str2 = names2.Peek();
            Console.WriteLine($"\nnames2 will serve soon element {str2}");
            Console.WriteLine("after peek:");
            foreach (string item in names2)
            {
                Console.Write(item + " ,");
            }
        }
    }
}
