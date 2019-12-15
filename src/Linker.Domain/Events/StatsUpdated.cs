using System.Collections.Generic;
using Evento;

namespace Linker.Domain.Events
{
    public class StatsUpdated : Event
    {
        public IDictionary<string, string> Metadata { get; }
    }
}
