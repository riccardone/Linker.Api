using System.Collections.Generic;

namespace Linker.Domain.Services
{
    public interface IStatsService
    {
        IDictionary<string, string> GetStats();
    }
}
