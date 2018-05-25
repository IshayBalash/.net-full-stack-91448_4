using System;

namespace _03_Person_class
{
    class Person
    {

        //----------------------------------constructor-----------------------------

        public Person():this(19, "Unknown"){
            Console.WriteLine("I AM CTOR THAT TAKES NO ARUMENTS");
        }


        public Person(string name) : this(18, name){
            Console.WriteLine("I AM CTOR THAT TAKES (string name) ARUMENT");
        }

        public Person(int age, string name)
        {
            Console.WriteLine("I AM CTOR THAT TAKES (int age, string name) ARUMENTS");
            Age = age;
            PersonName = name;
        }


        //-----------------------------------functions------------------------------
        public string GetFullDetails()
        {
            return $"Person age: {Age}, Person Name:{PersonName}";
        }

        //-----------------------------------properties-----------------------------

        private int age;

        public int Age
        {
            get { return age; }
            set { age = (value>=0 && value<=120)?value:18; }
        }


        private string personName;

        public string PersonName
        {
            get { return personName;; }
            set { personName = (value.Length>=2 && value.Length<=10)?value:"Unknown"; }
        }


    }
}
