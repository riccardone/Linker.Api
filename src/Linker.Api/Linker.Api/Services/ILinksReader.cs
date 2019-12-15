using System.Collections.Generic;
using Linker.Api.Models;

namespace Linker.Api.Services
{
    public interface ILinksReader
    {
        ExistingLink Get(string id);
        IEnumerable<ExistingLink> Get();
    }
}
