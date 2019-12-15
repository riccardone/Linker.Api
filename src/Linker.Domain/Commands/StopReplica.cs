using System.Collections.Generic;
using Evento;

namespace Linker.Domain.Commands
{
    public class StopReplica : Command
    {
        public IDictionary<string, string> Metadata { get; }
    }
}
