using DesignPatterns.Model;
using DesignPatterns.Model.Enum;

namespace DesignPatterns.Creational.Factory.AbstractFactory
{
    internal class ReturnInvoice : IInvoice
    {
        public Invoice Generate(Person customer, double amount)
        {
            return new Invoice(customer, amount, InvoiceType.Return);
        }
    }
}