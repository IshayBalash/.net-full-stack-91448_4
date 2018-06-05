namespace RentingLibrary
{
    public class Customer
    {
        public string FullName { get; set; }
        private int age { get; set; }

        internal int id { get; set; }
        protected internal int weight { get; set; }
        protected bool isMale { get; set; }
    }
}
