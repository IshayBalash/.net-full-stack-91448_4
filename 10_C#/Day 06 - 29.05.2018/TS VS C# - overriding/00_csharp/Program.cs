using System;

namespace csharp
{
    class A
    {
        public void GetInfo()
        {
            Console.WriteLine("A");
        }

    }

    class B : A
    {
        public void GetInfo()
        {
            Console.WriteLine("B");
        }
    }

    class C : B
    {
        public void GetInfo()
        {
            Console.WriteLine("C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //-------------A POINTER-----------------
            A a1 = new A();
            A a2 = new B();
            A a3 = new C();



            //-------------B POINTER-----------------
            B b1 = new B();
            B b2 = new C();


            //-------------C POINTER-----------------
            C c1 = new C();



            Console.WriteLine("------------A POINTER---------------");
            a1.GetInfo();
            a2.GetInfo();
            a3.GetInfo();

            Console.WriteLine("------------B POINTER---------------");
            b1.GetInfo();
            b2.GetInfo();

            Console.WriteLine("------------C POINTER---------------");
            c1.GetInfo();
        }
    }
}
