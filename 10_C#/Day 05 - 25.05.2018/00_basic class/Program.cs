using System;

namespace _00_basic_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight flight1 = new Flight();
            Flight flight2 = new Flight(-400);
            flight1.FlightPrice = -500;
            bool isCorrectPrice=flight1.CheckFlightPrice(500);

            Console.WriteLine(isCorrectPrice);  // --> true
        }
    }
}
