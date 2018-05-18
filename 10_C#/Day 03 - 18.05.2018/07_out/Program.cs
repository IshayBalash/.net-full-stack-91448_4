using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_out
{
    class Program
    {

        static void InitNum(out int param)
        {
            param = 6;
        }

        static void Main(string[] args)
        {
            int num1;

            //Console.WriteLine($"num1: {num1}");  //COMPILATION ERROR - Use of unassigned local variable 'num1'

            InitNum(out num1);

            Console.WriteLine($"num1: {num1}");
        }
    }
}
