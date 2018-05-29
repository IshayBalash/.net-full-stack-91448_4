using System;

namespace _04_oop
{
    abstract class Person
    {

        //-----------------constructor------------------------------
        public Person(int age, string fullName)
        {
            Age = age;
            FullName = fullName;
        }

        //--------------------------functions-------------------------
        public abstract string GetDescription();


        //--------------------------properties-------------------------

        public int Age { get; set; }
        public string FullName { get; set; }
    }
}
