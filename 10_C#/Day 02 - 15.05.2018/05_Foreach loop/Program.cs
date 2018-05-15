using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "c# is the best";

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"char number {i} is: {str[i]}");
            }

            foreach (char item in str)
            {
                Console.WriteLine(item);
            }
        }
    }
}


/*
 output:
 ----------------------------

 char number 0 is: c
char number 1 is: #
char number 2 is:
char number 3 is: i
char number 4 is: s
char number 5 is:
char number 6 is: t
char number 7 is: h
char number 8 is: e
char number 9 is:
char number 10 is: b
char number 11 is: e
char number 12 is: s
char number 13 is: t

c
#

i
s

t
h
e

b
e
s
t
 */
