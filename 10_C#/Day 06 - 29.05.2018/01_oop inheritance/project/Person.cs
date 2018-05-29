using System;

namespace _01_oop
{
    class Person
    {

        //-----------------constructor------------------------------
        public Person(int age, string fullName)
        {
            Age = age;
            FullName = fullName;
        }

        static Person()
        {
            Console.WriteLine("static ctor - Person");
        }


        //--------------------------functions-------------------------
        public string GetDescription()
        {
            return $"Person: Age:{Age}, FullName:{FullName}";
        }


        //--------------------------properties-------------------------

        public int Age { get; set; }
        public string FullName { get; set; }
    }
}
