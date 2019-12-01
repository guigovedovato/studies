using DesignPatterns.Model;

namespace DesignPatterns.Creational.Factory.AbstractFactory
{
    public interface IInvoice
    {
        Invoice Generate(Person customer, double amount);
    }
}