using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Journal
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public IEnumerable<string> Logs { get; set; }

        public bool Active { get; set; }

        public Author Author { get; set; }

        public static Journal Default { get; } = new Journal { Id = string.Empty, Active = true, Author = Author.Default, Logs = Enumerable.Empty<string>(), Title = "Default Journal" };
    }
}
