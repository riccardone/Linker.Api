using System.Collections.Generic;
using Evento;

namespace Linker.Domain.Commands
{
    public class GetStats : Command
    {
        public IDictionary<string, string> Metadata { get; }
    }
}
