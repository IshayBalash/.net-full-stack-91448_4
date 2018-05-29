using System;

namespace _02_oop
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
            return base.GetDescription()+$" Student: Grade: {Grade}";
        }


        //--------------------------properties-------------------------

        public int Grade { get; set; }
    }
}
