namespace _00_class_vs_struct
{
    class colorClass
    {
        public int Red;
        public int Green;
        public int Blue;
    }

    struct colorStruct
    {
        public int Red;
        public int Green;
        public int Blue;
    }


    class Program
    {
        static void Main(string[] args)
        {
            colorStruct c1;
            c1.Blue = 200;
            c1.Green = 200;
            c1.Red = 200;


            colorClass c2=new colorClass();
            c2.Blue = 200;
            c2.Green = 200;
            c2.Red = 200;
        }
    }
}
