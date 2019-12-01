namespace DesignPatterns.Creational.Factory.AbstractFactory
{
    internal class ReturnInvoiceFactory : IInvoiceFactory
    {
        public IInvoice GetInvoice()
        {
            return new ReturnInvoice();
        }
    }
}