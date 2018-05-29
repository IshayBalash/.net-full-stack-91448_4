using System;

namespace _04_oop
{
    class Student: Person
    {
        //-----------------constructor-------------------------------
        public Student(int age, string fullName, int grade) : base(age, fullName)
        {
            Grade = grade;
        }

        //--------------------------functions-------------------------
        public override string GetDescription()
        {
            return $"Student: Grade: {Grade}";
        }


        //--------------------------properties-------------------------

        public int Grade { get; set; }
    }
}
