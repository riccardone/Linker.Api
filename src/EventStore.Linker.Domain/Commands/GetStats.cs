using System.Collections.Generic;
using Evento;

namespace EventStore.Linker.Domain.Commands
{
    public class GetStats : Command
    {
        public IDictionary<string, string> Metadata { get; }
    }
}
