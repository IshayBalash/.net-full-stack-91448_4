using System;

namespace _04_Person_class
{
    class Person
    {

        //----------------------------------constructor-----------------------------

        public Person(int age, string name)
        {
            Age = age;
            PersonName = name;

            counter++;

            if(counter>=3 && counter <= 5)
            {
                Console.WriteLine($"{PersonName} is second generation");
            }
            
        }


        //בנאי סטטי שנקרא פעם אחת בלבד בשימוש הראשון במחלקה - בצורה אוטומטית - אי אפשר לקרוא לו בצורה יזומה
        static Person()
        {
            Console.WriteLine("The first person in the world was created now");
        }


        //-----------------------------------functions------------------------------
        public string GetFullDetails()
        {
            return $"Person age: {Age}, Person Name:{PersonName}";
        }

        //-----------------------------------properties-----------------------------

        private static int counter=0;

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
