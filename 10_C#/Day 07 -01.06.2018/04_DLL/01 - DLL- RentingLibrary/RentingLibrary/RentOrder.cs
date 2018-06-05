namespace RentingLibrary
{
    public class RentOrder
    {
        public Customer CustomerInfo { get; set; }
        public RentingItem RentItem { get; set; }
        public int DayOfRenting { get; set; }

        public RentOrder()
        {
            CustomerInfo = new Customer();

            /*
             Customer is a class in the current DLL, so we can only access 
                - public
                - internal 
                - protected internal 

             we can not access class member with the following: 
                - private 
                - protected  
             */

            CustomerInfo.FullName = "Alice";
            CustomerInfo.id = 1;
            CustomerInfo.weight = 40;

        }

        public override string ToString()
        {
            return $"{CustomerInfo.FullName} rented a {RentItem.name} for {DayOfRenting} days";
        }
    }
}
