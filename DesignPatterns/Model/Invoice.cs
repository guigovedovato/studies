using DesignPatterns.Model.Enum;

namespace DesignPatterns.Model
{
    public class Invoice
    {
        public Invoice(Person customer, double amount, InvoiceType type)
        {
            this.Customer = customer;
            this.Amount = amount;
            this.Type = type;
        }
        
        public Person Customer { get; set; }
        public double Amount { get; set; }
        public InvoiceType Type { get; set; }

        public override string ToString() => $"{nameof(Customer)}: {Customer}, {nameof(Amount)}: ${Amount}, {nameof(Type)}: {Type.ToString()},";
    }
}