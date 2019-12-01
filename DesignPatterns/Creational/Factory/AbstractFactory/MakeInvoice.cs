using System;
using System.Collections.Generic;
using DesignPatterns.Model.Enum;

namespace DesignPatterns.Creational.Factory.AbstractFactory
{
    public class MakeInvoice
    {
        private Dictionary<InvoiceType, IInvoiceFactory> factories = 
            new Dictionary<InvoiceType, IInvoiceFactory>();

        public MakeInvoice()
        {
            foreach (var t in typeof(IInvoiceFactory).Assembly.GetTypes())
            {
                if (typeof(IInvoiceFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    Enum.TryParse(t.Name.Replace("InvoiceFactory", string.Empty), true, out InvoiceType type);
                    factories.Add(type, (IInvoiceFactory)Activator.CreateInstance(t));
                }
            }
        }

        public IInvoice CreateInvoice(InvoiceType type)
        {
            return factories[type].GetInvoice();
        }
    }
}