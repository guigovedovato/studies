namespace MyVersionCSharpDesignPatterns.Creational.Builder
{
    class CodeBuilder
    {
        private Class _theClass = new Class();

        public CodeBuilder(string className)
        {
            _theClass.Name = className;
        }

        public CodeBuilder AddField(string name, string type)
        {
            _theClass.Fields.Add(new Field { Name = name, Type = type });
            return this;
        }

        public override string ToString()
        {
            return _theClass.ToString();
        }
    }
}
