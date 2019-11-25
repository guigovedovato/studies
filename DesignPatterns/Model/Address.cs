namespace DesignPatterns.Model
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }

        public override string ToString() => $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(Postcode)}: {Postcode}, {nameof(City)}: {City}";
    }
}