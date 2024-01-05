using VSAProjetoBase.Common;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;

namespace VSAProjetoBase.Common;

public static class DependencyInjection
{
    public static void AddEfCore(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(ServiceLifetime.Transient);
    }
}