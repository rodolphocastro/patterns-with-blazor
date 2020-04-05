using System.Collections.Generic;

namespace Models
{
    public class Journal
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public IEnumerable<string> Logs { get; set; }

        public bool Active { get; set; }

        public Author Author { get; set; }
    }
}
