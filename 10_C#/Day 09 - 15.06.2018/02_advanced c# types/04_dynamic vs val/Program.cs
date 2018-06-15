/*
var: (is checked befote runtime - in compilation)

* The contextual keyword 'var' may only appear within a local variable declaration or in script 
* var can not be the type of a returned value from a function
* var can not be the type of a paramter in a function
* var must get a value in the decleration line
* var can not change the type during runTime 
_____________________________________________


dynamic: (is not checked befote runtime)

* dynamic is not checked in compilation time (only in runtime)
* dynamic can be the type of a returned value from a function
* dynamic can be the type of a paramter in a function
* dynamic do not requier a value in the decleration line
* dynamic can change the type during runTime 

 */

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
        static dynamic printInfo(dynamic person)
        {
            return ($"Person info: {person.FirstName} {person.LastName} {person.Country}");
        }

        static void Main(string[] args)
        {

            var person = new { FirstName="Bob", LastName="Levi",Country= Countries .Israel};
            Console.WriteLine(printInfo(person));

            person = new {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Country = Countries.UK
            };
            Console.WriteLine(printInfo(person)); 


        }
    }
}


/*
 
OUTPUT:
_________________________

Person info: Bob Levi Israel
Person info: Bob Levi UK
   
*/
