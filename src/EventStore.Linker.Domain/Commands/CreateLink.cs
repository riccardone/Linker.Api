using System.Collections.Generic;
using Evento;

namespace EventStore.Linker.Domain.Commands
{
    public class CreateLink : Command
    {
        public IDictionary<string, string> Metadata { get; }
    }
}
