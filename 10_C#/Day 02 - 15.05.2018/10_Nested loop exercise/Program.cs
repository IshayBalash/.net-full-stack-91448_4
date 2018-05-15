using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Nested_Loop_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
    
            bool flag;
            string str;
            do
            {
                Console.WriteLine("please insert a number");
                str = Console.ReadLine();
                int i;
                for (i = 0; i < str.Length; i++)
                {
                    //check if current char is numeric
                    if(!(str[i] >= 48 && str[i] <= 57))
                    {
                        break;
                    }
                }

                flag = (i == str.Length);

            } while (!flag);

            int num = Convert.ToInt32(str);

            for (int outer = 0; outer < num; outer++)
            {
                for (int inner = 0; inner < outer+1; inner++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
