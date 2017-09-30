namespace BaltaStore.Domain.StoreContext.ValueObjects
{
    public class Document
    {
        public Document(string number)
        {
            Number = number;        
        }

        public string Number { get; private set; }

        public override string ToString()
        {
            return Number;
        }
    }
}
