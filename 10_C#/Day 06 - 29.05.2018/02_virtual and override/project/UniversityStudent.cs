using System;

namespace _02_oop
{
    class UniversityStudent:Student
    {

        //-----------------constructor------------------------------
        public UniversityStudent(int age, string fullName, int grade, string universityName) :base(age,fullName,grade)
        {
            UniversityName = universityName;
        }

        //--------------------------functions-------------------------
        public override string GetDescription()
        {
            return base.GetDescription() + $" UniversityStudent: UniversityName:{UniversityName}";
        }


        //--------------------------properties-------------------------

        public string UniversityName { get; set; }
    }
}
