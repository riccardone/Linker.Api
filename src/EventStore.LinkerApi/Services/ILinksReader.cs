using System.Collections.Generic;
using EventStore.LinkerApi.Models;

namespace EventStore.LinkerApi.Services
{
    public interface ILinksReader
    {
        ExistingLink Get(string id);
        IEnumerable<ExistingLink> Get();
    }
}
