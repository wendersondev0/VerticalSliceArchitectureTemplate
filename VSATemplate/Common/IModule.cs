using Microsoft.Extensions.DependencyInjection;

namespace VerticalSliceArchitectureTemplate.Common;

public interface IModule
{
    static abstract void ConfigureServices(IServiceCollection services);
}