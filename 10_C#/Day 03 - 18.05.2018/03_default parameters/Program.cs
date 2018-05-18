using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_default_parameters
{
    class Program
    {
   
        static void PrintStudentInfo(string name, int age, bool gender = true, int grade = 100)
        {
            Console.WriteLine($"{name} is {age} years old, isMale: {gender}, and grade is {grade}");
        }



        //**********************press "///" and get the following comment template:*****************
        /// <summary>
        /// this function prints the info of a specific person
        /// </summary>
        /// <param name="name">only first name</param>
        /// <param name="age">range 0-120</param>
        /// <param name="gender">male is true, female is false</param>
        static void PrintPersonInfo(string name, int age, bool gender=true)
        {
            Console.WriteLine($"{name} is {age} years old, isMale: {gender}");
        }

 

        static void Main(string[] args)
        {

            PrintPersonInfo("Alice", 20, false);
            PrintPersonInfo("Bob", );


            PrintStudentInfo("Tzahi", 18);
            PrintStudentInfo("Lera", 18,false);
            PrintStudentInfo("Meir", 18, true,99);
            PrintStudentInfo(age:18, grade:99, name: "Meir");
        }
    }
}


/*
 
output:
__________________________________
 
Alice is 20 years old, isMale: False
Bob is 23 years old, isMale: True
Tzahi is 18 years old, isMale: True, and grade is 100
Lera is 18 years old, isMale: False, and grade is 100
Meir is 18 years old, isMale: True, and grade is 99
Meir is 18 years old, isMale: True, and grade is 99
*/
