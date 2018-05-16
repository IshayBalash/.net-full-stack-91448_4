using System;


//DRY = Dont Repeat Yourself


namespace Basic_string_and_debugging
{
    class Program
    {

        static void PrintStr(string str1, string str2)
        {
            Console.WriteLine($" str1: {str1} \n str2: {str2} \n\n");
        }

        static void Main(string[] args)
        {

            string str1 = "I am str1", str2 = "I am str2";

            str1 = "Jerusalem is our capital city";
            str2 = str1;
            PrintStr(str1,str2);


            str1 = "Tel Aviv is an intresting city";
            PrintStr(str1, str2);

            Console.ReadLine();

        }
    }
}
