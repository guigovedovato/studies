using System;
using DesignPatterns.Creational.Builder.Faceted;
using DesignPatterns.Creational.Builder.Fluent;
using DesignPatterns.Creational.Builder.Functional;
using DesignPatterns.Creational.Factory.AbstractFactory;
using DesignPatterns.Creational.Factory.FactoryMethod;
using DesignPatterns.Creational.Factory.InnerFactory;
using DesignPatterns.Model;
using DesignPatterns.Model.Enum;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creational

            #region Builder

            #region Fluent Builder

            Console.WriteLine("Creational -> Builder -> Fluent Builder");

            var fluentBuilder = new PersonFluentBuilder();
            Console.WriteLine(
                fluentBuilder.AddName("Rodrigo")
                .AddSurname("Vedovato")
                .AddPosition(Position.SoftwareEngineer)
                .AddDateOfBirth(new DateTime(1985, 02, 07))
                .Build()
            );
            
            Console.WriteLine("----------------------------------------------");

            #endregion Fluent Builder

            #region Functional Builder

            Console.WriteLine("Creational -> Builder -> Functional Builder");

            var functionalBuilder = new PersonFunctionalBuilder();
            Console.WriteLine(
                functionalBuilder.AddName("Rodrigo")
                .AddSurname("Vedovato")
                .AddPosition(Position.SoftwareEngineer)
                .AddDateOfBirth(new DateTime(1985, 02, 07))
                .Build()
            );
            
            Console.WriteLine("----------------------------------------------");

            #endregion Functional Builder

            #region Faceted Builder

            Console.WriteLine("Creational -> Builder -> Faceted Builder");

            var facetedlBuilder = new PersonFacetedBuilder();
            Person person = facetedlBuilder
                    .Is.Called("Rodrigo")
                       .WithLastName("Vedovato")
                       .BirthAt(new DateTime(1985, 02, 07))
                    .Works.At("Altran Portugal S.A.")
                          .AsA(Position.SoftwareEngineer)
                    .Lives.At("Porto")
                          .WithPostcode("123-1212-09")
                          .In("Portugal");
            Console.WriteLine(person);
            
            Console.WriteLine("----------------------------------------------");

            #endregion Faceted Builder

            #endregion Builder

            #region Factory

            #region Factory Method

            Console.WriteLine("Creational -> Factory -> Factory Method");

            var customerInvoice = InvoiceNumber.NewInvoiceNumberCustomer(2019, 11, 123456);
            var MerchantInvoice = InvoiceNumber.NewInvoiceNumberMerchant(2019, 11, 123456);
            Console.WriteLine(customerInvoice);
            Console.WriteLine(MerchantInvoice);
            
            Console.WriteLine("----------------------------------------------");

            #endregion Factory Method

            #region Inner Factory 

            Console.WriteLine("Creational -> Factory -> Inner Factory");
            var personOrder = OrderNumber.Factory.NewOrderNumberForPerson(2019, 11, 123456);
            var companyOrder = OrderNumber.Factory.NewOrderNumberForCompany(2019, 11, 123456);
            Console.WriteLine(personOrder);
            Console.WriteLine(companyOrder);
            
            Console.WriteLine("----------------------------------------------");

            #endregion Inner Factory

            #region Abstract Factory 

            Console.WriteLine("Creational -> Factory -> Abstract Factory");

            var makeInvoice = new MakeInvoice();
            var invoice = makeInvoice
                            .CreateInvoice(InvoiceType.Sale)
                            .Generate(person, 133.98);
            Console.WriteLine(invoice);
            
            Console.WriteLine("----------------------------------------------");

            #endregion Abstract Factory

            #endregion Factory

            #region Prototype

            Console.WriteLine("Creational -> Prototype -> ");

            
            
            Console.WriteLine("----------------------------------------------");

            #endregion Prototype

            #endregion Creational
        }
    }
}
