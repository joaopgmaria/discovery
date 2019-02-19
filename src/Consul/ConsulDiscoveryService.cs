using Consul;
using Discovery.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discovery.Consul
{
    public class ConsulDiscoveryService : IDiscoveryService
    {
        private IConsulClient _client;

        public ConsulDiscoveryService(IConsulClient client)
        {
            _client = client;
        }

        public async Task Deregister(IServiceDefinition service)
        {
            await _client.Agent.ServiceDeregister(service.Name());
        }

        public Task<IEnumerable<IServiceDefinition>> Discover(string query)
        {
            throw new NotImplementedException();
        }

        public async Task Register(IServiceDefinition service)
        {
            var registration = new AgentServiceRegistration()
            {
                Name = service.Name()
            };

            await _client.Agent.ServiceRegister(registration);
        }
    }
}
