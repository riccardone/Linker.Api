using System.Collections.Generic;
using Evento;

namespace Linker.Domain.Commands
{
    public class ChangeDestination : Command
    {
        public IDictionary<string, string> Metadata { get; }
    }
}
