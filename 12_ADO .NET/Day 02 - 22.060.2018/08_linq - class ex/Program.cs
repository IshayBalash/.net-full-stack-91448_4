using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_linq_class_ex
{


    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>
            {
                new Person {Age=22,Name="Tom",Id=1 },
                new Person {Age=33,Name="Bob",Id=2 },
                new Person {Age=44,Name="Alice",Id=3 }
            };


            IEnumerable<int> res1 = list.Select((Person p) => { return p.Age; });

            foreach (int item in res1)
            {
                Console.WriteLine(item);
            }
        }
    }
}


/*
OUTPUT:
__________________________

22
33
44     
*/
