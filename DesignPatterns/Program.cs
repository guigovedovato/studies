using System;
using DesignPatterns.Creational.Builder.Fluent;
using DesignPatterns.Creational.Builder.Functional;
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
                .Build().ToString()
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
                .Build().ToString()
            );
            
            Console.WriteLine("----------------------------------------------");

            #endregion Functional Builder

            #endregion Builder

            #endregion Creational
        }
    }
}
