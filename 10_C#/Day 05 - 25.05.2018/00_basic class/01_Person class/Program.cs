using System;

namespace _01_Person_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person("Bob");
            Person person3 = new Person(16,"Alice");

            Console.WriteLine(person1.GetFullDetails());
            Console.WriteLine(person2.GetFullDetails());
            Console.WriteLine(person3.GetFullDetails());
        }
    }
}



/*
OUTPUT:
____________________________________

Person age: 19 , Person Name:Unknown
Person age: 18, Person Name:Bob
Person age: 16, Person Name:Alice    
     
 */
