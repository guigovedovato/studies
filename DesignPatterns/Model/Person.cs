using System;
using DesignPatterns.Model.Enum;

namespace DesignPatterns.Model
{
    public class Person
    {
        public Person()
        {
            this.Address = new Address();
            this.Job = new Works();
        }
        
        public Works Job { get; set; }
        public Address Address { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString() => $"{nameof(Name)}: {Name}, {nameof(Surname)}: {Surname}, {nameof(DateOfBirth)}: {DateOfBirth.ToString("dd/MM/yyyy")}, {nameof(Address)}: {Address}, {nameof(Job)}: {Job}";
    }
}