using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Journal : ICloneable
    {
        public Journal()
        {

        }

        public Journal(Journal j)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }

            Id = j.Id;
            Title = j.Title;
            Logs = j.Logs;
            Active = j.Active;
            Author = new Author(j.Author);
        }
        public string Id { get; set; }

        public string Title { get; set; }

        public IEnumerable<string> Logs { get; set; }

        public bool Active { get; set; }

        public Author Author { get; set; }

        public static Journal Default { get; } = new Journal { Id = string.Empty, Active = true, Author = Author.Default, Logs = Enumerable.Empty<string>(), Title = "Default Journal" };

        public object Clone() => new Journal(this);
    }
}
