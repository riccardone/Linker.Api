using System.Collections.Generic;
using Evento;

namespace Linker.Domain.Events
{
    public class LinkStarted : Event
    {
        public IDictionary<string, string> Metadata { get; }
    }
}
