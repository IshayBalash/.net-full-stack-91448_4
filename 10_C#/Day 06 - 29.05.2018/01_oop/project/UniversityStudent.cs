using System;

namespace _00_oop
{
    class UniversityStudent:Student
    {

        //-----------------constructor------------------------------
        public UniversityStudent(int age, string fullName, int grade, string universityName) :base(age,fullName,grade)
        {
            UniversityName = universityName;
        }

        static UniversityStudent()
        {
            Console.WriteLine("static ctor - UniversityName");
        }


        //--------------------------functions-------------------------
        public string GetDescription()
        {
            return $"SchoolStudent: UniversityName:{UniversityName}";
        }


        //--------------------------properties-------------------------

        public string UniversityName { get; set; }
    }
}
