using System;

namespace Models
{
    public class Author : ICloneable
    {
        public Author()
        {

        }

        public Author(Author a)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a));
            }

            Name = a.Name;
            Biography = a.Biography;
        }

        public string Name { get; set; }

        public string Biography { get; set; }

        public override string ToString() => Name;

        public static Author Default { get; } = new Author { Name = "John Doe", Biography = "Lorem Ipsum Dolor sit amet" };
        public object Clone() => new Author(this);
    }
}