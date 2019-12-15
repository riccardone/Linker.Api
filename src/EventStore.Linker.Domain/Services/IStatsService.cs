using System.Collections.Generic;

namespace EventStore.Linker.Domain.Services
{
    public interface IStatsService
    {
        IDictionary<string, string> GetStats();
    }
}
