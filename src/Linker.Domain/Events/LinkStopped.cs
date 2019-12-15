using System.Collections.Generic;
using Evento;

namespace Linker.Domain.Events
{
    public class LinkStopped : Event
    {
        public IDictionary<string, string> Metadata { get; }
    }
}
