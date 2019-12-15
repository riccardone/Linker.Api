using System.Collections.Generic;
using Evento;

namespace EventStore.Linker.Domain.Commands
{
    public class ChangeDestination : Command
    {
        public IDictionary<string, string> Metadata { get; }
    }
}
