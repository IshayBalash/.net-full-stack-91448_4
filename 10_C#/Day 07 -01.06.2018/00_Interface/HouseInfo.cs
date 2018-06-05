namespace _00_Interface
{
    abstract class HouseInfo: IPayRent
    {
        public Address HouseAddress { get; set; }
        private int floorCount;

        public int FloorCount
        {
            get { return floorCount; }
            set { floorCount = (value>0)? value:1; }
        }

        public bool IsRented { get; set; }



        //------------------IMPLEMENTATION OF IPayRent------------------------
        private int rentAmount;
        public int RentAmount
        {
            get
            {
                return rentAmount;
            }

            set
            {
                rentAmount = (value > 1000) ? value : 1000;
            }
        }

        public int PayRent(int payAmount)
        {
            //return change to customer
            return payAmount - RentAmount;
        }
    }
}
