namespace Generics
{
    interface ISend
    {
        void Send(string phone);
        string Addressee { get; set; }
    }
}
