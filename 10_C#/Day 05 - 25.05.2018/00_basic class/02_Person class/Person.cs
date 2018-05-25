namespace _02_Person_class
{
    class Person
    {

        //----------------------------------constructor-----------------------------

        public Person():this(19, "Unknown"){  }

        public Person(string name) : this(18, name){ }

        public Person(int age, string name)
        {
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
