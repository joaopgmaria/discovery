using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discovery.Core
{
    public interface IDiscoveryService
    {
        Task Register(IServiceDefinition service);

        Task Deregister(IServiceDefinition service);

        Task<IEnumerable<IServiceDefinition>> Discover(string query);
    }
}
