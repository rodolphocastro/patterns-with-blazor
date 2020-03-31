using Microsoft.Extensions.Logging;

namespace Models.Builders
{
    public class InheritablePersonBuilder : InheritableFluentPersonBuilder<InheritablePersonBuilder>
    {
        public InheritablePersonBuilder(ILogger<InheritablePersonBuilder> logger = null) : base(logger)
        {
            
        }

        internal InheritablePersonBuilder() { }
    }

}
