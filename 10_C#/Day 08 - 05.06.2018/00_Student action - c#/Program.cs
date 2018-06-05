using System;
using System.Windows.Forms;

namespace _00_Student_action
{

    class Program
    {
        static void Main(string[] args)
        {

            // we have an array with 2 students: Assa , Meir
            Student[] studentsArray = { new Student("Assa"), new Student("Meir") };
            string[] subjectArray = { "Math", "Music", "Sport", "Physics" };

            foreach (string str in subjectArray)
            {
                foreach (Student student in studentsArray)
                {

                    if (student.StudentName == "Assa" && str == "Math")
                    {
                        student.Subject = str;
                        student.SubjectReactionFunc = (string subject) =>
                        {
                            Console.WriteLine($"When I party, I learn {subject}");
                        };
                    }


                    if (student.StudentName == "Meir" && str == "Physics")
                    {
                        student.Subject = str;
                        student.SubjectReactionFunc = (string subject) =>
                        {
                            MessageBox.Show($"{subject} is Great");
                        };
                    }
                }
            }


            foreach (Student student in studentsArray)
            {
                Console.WriteLine($"{student.StudentName}, {student.Subject}");
                student.SubjectReactionFunc(student.Subject);
            }
            }
    }
}
