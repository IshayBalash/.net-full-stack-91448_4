namespace RentingLibrary
{
    public abstract class RentingItem
    {
        public int PricePerDay { get; set; }
        internal protected string name { get; set; }
        protected  string description { get; set; }
    }
}
