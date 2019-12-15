using System.Threading.Tasks;
using EventStore.Linker.Domain.Aggregates;

namespace EventStore.Linker.Domain.Services
{
    public interface ILinkService
    {
        Link Link { get; }
        Task Start();
        Task Stop();
    }
}
