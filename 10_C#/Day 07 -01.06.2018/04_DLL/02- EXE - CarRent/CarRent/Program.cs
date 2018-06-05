using System;
using RentingLibrary;

namespace CarRent
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             we can only access "public" class members - 
             because "Customer" is a class from external DLL
             
            we can not access class member with the following: 
                - private 
                - internal 
                - protected internal 
                - protected  
 
             */
            Customer customer = new Customer();
            customer.FullName = "Bob";

            RentOrder carOrder = new RentOrder();
            carOrder.RentItem = new Car { Color = "Red" };
            carOrder.DayOfRenting = 4;
            carOrder.CustomerInfo = customer;

            Console.WriteLine(carOrder);
        }
    }
}
