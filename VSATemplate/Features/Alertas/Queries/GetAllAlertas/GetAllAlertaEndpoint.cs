using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using VerticalSliceArchitectureTemplate.Common;

namespace VerticalSliceArchitectureTemplate.Features.Alertas.Queries.GetAllAlertas;

public sealed class GetAllAlertasEndpoint : IEndpoint
{
    public static void MapEndpoint(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGetWithOpenApi<Alerta[]>("/alertas", HandleAsync)
            .WithTags(nameof(Alerta));
    }

    public static async Task<IResult> HandleAsync(IAlertaRepository alertaRepository,
        CancellationToken cancellationToken)
    {
        var output = await alertaRepository.GetAllAsync(cancellationToken);

        return Results.Ok(output);
    }
}