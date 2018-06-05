using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_sealed_class
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.num);

            Console.WriteLine(B.num);
        }
    }


    //cannot derive from sealed type 'A'	
    //can contain non-static ctor / function / properties
    //Can declare a variable of static type 'B'
    sealed class A
    {
        public int num { get; set; } = 7;
    }


    //cannot derive from static class 'B'	
    //cannot contain non-static ctor / function / properties
    //Cannot declare a variable of static type 'B'	
    static class B
    {
        public static int num { get; set; } = 2;
    }

   
}
