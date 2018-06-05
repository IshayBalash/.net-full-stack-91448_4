using System;

namespace _00_Interface
{
    class BikeRent : IPayRent
    {
        public int RentAmount { get; set; }

        public int HourAmount { get; set; }

        public int PayRent(int payAmount)
        {
            Console.WriteLine("I am keeping the change for myself :)");
            return 0;
        }
    }
}
