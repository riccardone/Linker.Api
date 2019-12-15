using System.Collections.Generic;
using Evento;

namespace Linker.Domain.Commands
{
    public class ChangeOrigin : Command
    {
        public IDictionary<string, string> Metadata { get; }
    }
}
