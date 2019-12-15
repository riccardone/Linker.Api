using System.Collections.Generic;
using Evento;

namespace EventStore.Linker.Domain.Events
{
    public class StatsUpdated : Event
    {
        public IDictionary<string, string> Metadata { get; }
    }
}
