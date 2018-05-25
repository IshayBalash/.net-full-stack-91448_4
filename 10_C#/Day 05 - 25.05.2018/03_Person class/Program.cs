using System;

namespace _03_Person_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine("------------------------------");

            Person person2 = new Person("Bob");
            Console.WriteLine("------------------------------");

            Person person3 = new Person(16,"Alice");
            Console.WriteLine("------------------------------");

            Console.WriteLine(person1.GetFullDetails());
            Console.WriteLine(person2.GetFullDetails());
            Console.WriteLine(person3.GetFullDetails());
        }
    }
}



/*
OUTPUT:
____________________________________

I AM CTOR THAT TAKES (int age, string name) ARUMENTS
I AM CTOR THAT TAKES NO ARUMENTS
------------------------------
I AM CTOR THAT TAKES (int age, string name) ARUMENTS
I AM CTOR THAT TAKES (string name) ARUMENT
------------------------------
I AM CTOR THAT TAKES (int age, string name) ARUMENTS
------------------------------
Person age: 19, Person Name:Unknown
Person age: 18, Person Name:Bob
Person age: 16, Person Name:Alice  
     
 */
