using System;

namespace _03_oop
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
        public override string GetDescription()
        {
            return $"Person: Age:{Age}, FullName:{FullName}";
        }


        //--------------------------properties-------------------------

        public int Age { get; set; }
        public string FullName { get; set; }
    }
}
