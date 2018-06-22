using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_linq_class_ex
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


            var res1 = list.Select((Person p) => { return new { Age=p.Age,Name=p.Name }; });

            foreach (var item in res1)
            {
                Console.WriteLine($"{item.Name} is {item.Age} years old");
            }


            IEnumerable<object> res2 = list.Select((Person p) => { return new { Age = p.Age, Name = p.Name }; });

            foreach (var item in res2)
            {

                //'object' does not contain a definition for 'Age' and no extension method 'Age' accepting a first argument of type 'object' 
                //could be found(are you missing a using directive or an assembly reference ?)	

                //Console.WriteLine(item.Age); //--> COMPILATION ERROR
            }
        }
    }
}


/*
OUTPUT:
__________________________

Tom is 22 years old
Bob is 33 years old
Alice is 44 years old    
*/
