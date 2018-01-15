namespace MyVersionCSharpDesignPatterns.Structural.Decorator
{
    public class Dragon
    {
        private int age;
        private Bird bird = new Bird();
        private Lizard lizard = new Lizard();

        public int Age
        {
            set { age = bird.Age = lizard.Age = value; }
            get { return age; }
        }

        public string Fly()
        {
            return bird.Fly();
        }

        public string Crawl()
        {
            return lizard.Crawl();
        }
    }
}
