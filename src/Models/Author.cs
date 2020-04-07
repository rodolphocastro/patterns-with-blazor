namespace Models
{
    public class Author
    {
        public string Name { get; set; }

        public string Biography { get; set; }

        public override string ToString() => Name;

        public static Author Default { get; } = new Author { Name = "John Doe", Biography = "Lorem Ipsum Dolor sit amet" };
    }
}