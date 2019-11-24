using System;
using DesignPatterns.Model.Enum;

namespace DesignPatterns.Model
{
    public class Person
    {
        public string Name { get; set; }
        public Position Position { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString() => $"Name: {Name}, Surname: {Surname}, Position: {Position}, Birth: {DateOfBirth.ToString("dd/MM/yyyy")}";
    }
}