using System;

namespace Discovery.Core
{
    public interface IHTTPServiceDefinition : IServiceDefinition
    {
        Uri URL();
    }
}
