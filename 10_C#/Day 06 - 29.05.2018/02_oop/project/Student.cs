using System;

namespace _00_oop
{
    class Student: Person
    {
        //-----------------constructor-------------------------------
        public Student(int age, string fullName, int grade) : base(age, fullName)
        {
            Grade = grade;
        }

        static Student()
        {
            Console.WriteLine("static ctor -Student");
        }

        //--------------------------functions-------------------------
        public string GetDescription()
        {
            return $"Student: Grade: {Grade}";
        }


        //--------------------------properties-------------------------

        public int Grade { get; set; }
    }
}
