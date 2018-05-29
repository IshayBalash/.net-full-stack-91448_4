using System;
using System.Collections.Generic;

namespace _00_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Person(20,"Tom"));
            personList.Add(new Student(18,"Bob",100));
            personList.Add(new SchoolStudent(10,"Alice",89,"Ben Gurion"));
            personList.Add(new UniversityStudent(22,"Mike",100,"Tel-Aviv"));


            foreach (Person item in personList)
            {
                Console.WriteLine(item.GetDescription());
            }

        }
    }
}


/*

OUTPUT:
 __________________________

static ctor - Person
static ctor -Student
static ctor - SchoolStudent
static ctor - UniversityName
Person: Age:20, FullName:Tom
Person: Age:18, FullName:Bob
Person: Age:10, FullName:Alice
Person: Age:22, FullName:Mike
 
     
*/
