namespace _00_Interface
{
    class Address
    {

        //----------------------Constructor---------------------------
        public Address(string country, string city)
        {
            Country = country;
            City = city;

        }


        //----------------------Functions---------------------------

        public override string ToString()
        {
            return $"{HouseNumber} {Street} st. / {City} / {Country}";
        }

        //----------------------Properties---------------------------
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }


        private int houseNumber;

        public int HouseNumber
        {
            get { return houseNumber; }
            set { houseNumber = (value>0)?value:1; }
        }




    }
}
