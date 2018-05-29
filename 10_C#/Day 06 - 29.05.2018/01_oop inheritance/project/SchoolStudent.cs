using System;

namespace _01_oop
{
    class SchoolStudent:Student
    {

        //-----------------constructor------------------------------
        public SchoolStudent(int age, string fullName,int grade, string schoolName):base(age,fullName,grade)
        {
            SchoolName = schoolName;
        }

        static SchoolStudent()
        {
            Console.WriteLine("static ctor - SchoolStudent");
        }


        //--------------------------functions-------------------------
        public string GetDescription()
        {
            return $"SchoolStudent: SchoolName:{SchoolName}";
        }


        //--------------------------properties-------------------------

        public string SchoolName  { get; set; }
    }
}
