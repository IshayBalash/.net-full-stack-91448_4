namespace _00_Student_action
{


    /// <summary>
    /// here we created a delegate
    /// a delegate defines a type of a function
    /// and creates a new type that we will use later to define othe var types
    /// </summary>
    /// this type defines a function that gets one string parameter and returns void
    delegate void SubjectReaction(string subject);


    class Student
    {
        public string StudentName { get; set; }
        public string Subject { get; set; }

        //לא יודעים מה תהיה התגובה - ידוע שתהיה תגובה
        //פונקציה שמקבלת מחרוזת ולא מחזירה ערך
        public SubjectReaction SubjectReactionFunc { get; set; }

        public Student(string studentName)
        {
            StudentName = studentName;
        }
    }
}
