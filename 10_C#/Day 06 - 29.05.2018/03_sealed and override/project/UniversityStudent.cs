using System;

namespace _03_oop
{
    class UniversityStudent:Student
    {

        //-----------------constructor------------------------------
        public UniversityStudent(int age, string fullName, int grade, string universityName) :base(age,fullName,grade)
        {
            UniversityName = universityName;
        }

        //--------------------------functions-------------------------
        public string GetDescription()
        {
            return $"UniversityStudent: UniversityName:{UniversityName}";
        }


        //--------------------------properties-------------------------

        public string UniversityName { get; set; }
    }
}
