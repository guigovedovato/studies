using System;
using DesignPatterns.Creational.Builder.Fluent;
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
            var pb = new PersonBuilder();
            Console.WriteLine(
                pb.AddName("Rodrigo")
                .AddSurname("Vedovato")
                .AddPosition(Position.SoftwareEngineer)
                .AddDateOfBirth(new DateTime(1985, 02, 07))
                .Build().ToString()
            );
            
            Console.WriteLine("----------------------------------------------");

            #endregion Fluent Builder

            #endregion Builder

            #endregion Creational
        }
    }
}
