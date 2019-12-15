using System.Threading.Tasks;
using Linker.Domain.Aggregates;

namespace Linker.Domain.Services
{
    public interface ILinkService
    {
        Link Link { get; }
        Task Start();
        Task Stop();
    }
}
