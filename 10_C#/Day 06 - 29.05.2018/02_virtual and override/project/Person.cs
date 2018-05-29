using System;

namespace _02_oop
{
    class Person
    {

        //-----------------constructor------------------------------
        public Person(int age, string fullName)
        {
            Age = age;
            FullName = fullName;
        }

        //--------------------------functions-------------------------
        public virtual string GetDescription()
        {
            return $"Person: Age:{Age}, FullName:{FullName}";
        }


        //--------------------------properties-------------------------

        public int Age { get; set; }
        public string FullName { get; set; }
    }
}
