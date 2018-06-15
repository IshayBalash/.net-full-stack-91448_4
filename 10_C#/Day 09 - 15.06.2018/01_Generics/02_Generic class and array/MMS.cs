namespace Generics
{
    public class MMS<TSubject, TMessage, TImage> : SMS<TSubject, TMessage>
    {
        public TImage ImageMsg { get; set; }

    }
}
