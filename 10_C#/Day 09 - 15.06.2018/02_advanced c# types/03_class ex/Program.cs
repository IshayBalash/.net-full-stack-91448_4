using System;

namespace _03_class_ex
{


    enum Countries
    {
        Israel,
        UK,
        USA
    }
    class Program
    {
        static void Main(string[] args)
        {

            var person = new { FirstName="Bob", LastName="Levi",Country= Countries .Israel};

            Console.WriteLine($"Person info step 1: {person.FirstName} {person.LastName} {person.Country}");

            person = new {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Country = Countries.UK
            };

            Console.WriteLine($"Person info step 2: {person.FirstName} {person.LastName} {person.Country}");

        }
    }
}


/*
 
OUTPUT:
_________________________

Person info step 1: Bob Levi Israel
Person info step 2: Bob Levi UK
   
*/
