using RentingLibrary;


namespace CarRent
{
    class Car:RentingItem
    {

        public string Color { get; set; }
        public Car()
        {
            /*
             RentingItem is a class in an external DLL, so we can only access 
                - public
                - protected 
                - protected internal 

             we can not access class member with the following: 
                - private 
                - internal  
             */
            PricePerDay = 200;
            description = "A car for a good ride";
            name = "Toyota car";
        }
    }
}
