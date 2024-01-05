using Microsoft.Extensions.DependencyInjection;
using VerticalSliceArchitectureTemplate.Common;

namespace VerticalSliceArchitectureTemplate.Features.Alertas;
public sealed class AlertaModule : IModule
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IAlertaRepository, AlertaRepository>();
    }
}