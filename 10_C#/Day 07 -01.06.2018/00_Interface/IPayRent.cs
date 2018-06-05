namespace _00_Interface
{
    interface IPayRent
    {
        int RentAmount { get; set; }
        int PayRent(int payAmount);

    }
}
