namespace DesignPatterns.Creational.Factory.AbstractFactory
{
    internal class SaleInvoiceFactory : IInvoiceFactory
    {
        public IInvoice GetInvoice()
        {
            return new SaleInvoice();
        }
    }
}