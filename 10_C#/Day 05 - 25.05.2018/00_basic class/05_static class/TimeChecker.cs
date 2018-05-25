using System;


namespace _05_static_class
{
    static class TimeChecker
    {

        //-------------------------------properties--------------------------

        //משתנה שיאותחל פעם אחת בלבד בבנאי הסטטי ויאחסן את הזמן בו בוצעה לראשונה פניה למחלקה
        private static DateTime startDate;

        //משתנה סטטי
        //מחזיר את ההפרש בין הזמן הנוכחי לזמן בו בוצעה לראשונה קריאה למחלקה
        public static TimeSpan DiffDate
        {
            get { return (DateTime.Now)- (startDate); }
        }


        //--------------------------------constructor-------------------------

        //בנאי סטטי שרץ בפעם הראשונה שפנינו למחלקה
        //בבנאי זה נאתחל את שעת ההתחלה לתאריך הנוכחי בו ארע הבנאי
        static TimeChecker()
        {
            startDate = DateTime.Now;
        }


        //-------------------------------functions--------------------------

        public static string getFullDate()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
