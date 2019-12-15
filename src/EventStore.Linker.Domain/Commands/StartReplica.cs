using System.Collections.Generic;
using Evento;

namespace EventStore.Linker.Domain.Commands
{
    public class StartReplica : Command
    {
        public IDictionary<string, string> Metadata { get; }
    }
}
