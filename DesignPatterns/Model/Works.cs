using DesignPatterns.Model.Enum;

namespace DesignPatterns.Model
{
    public class Works
    {
        public Position Position { get; set; }
        public string Company { get; set; }

        public override string ToString() => $"{nameof(Company)}: {Company}, {nameof(Position)}: {Position},";
    }
}