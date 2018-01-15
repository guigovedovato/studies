using System.Collections.Generic;
using System.Text;

namespace MyVersionCSharpDesignPatterns.Creational.Builder
{
    public class Class
    {
        public string Name { get; set; }
        public List<Field> Fields { get; set; }

        public Class() => Fields = new List<Field>();

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"public class {Name}").AppendLine("{");
            foreach (var field in Fields)
                stringBuilder.AppendLine($"  {field};");
            stringBuilder.AppendLine("}");
            return stringBuilder.ToString();
        }
    }
}
