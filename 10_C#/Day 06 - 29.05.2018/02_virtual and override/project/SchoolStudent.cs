using System;

namespace _02_oop
{
    class SchoolStudent:Student
    {

        //-----------------constructor------------------------------
        public SchoolStudent(int age, string fullName,int grade, string schoolName):base(age,fullName,grade)
        {
            SchoolName = schoolName;
        }

        //--------------------------functions-------------------------
        public override string GetDescription()
        {
            return base.GetDescription()+$" SchoolStudent: SchoolName:{SchoolName}";
        }


        //--------------------------properties-------------------------

        public string SchoolName  { get; set; }
    }
}
