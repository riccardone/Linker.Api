using System.Collections.Generic;
using Evento;

namespace Linker.Domain.Events
{
    public class LinkCreated : Event
    {
        public IDictionary<string, string> Metadata { get; }
    }
}
