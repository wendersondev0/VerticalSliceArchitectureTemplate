using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using VerticalSliceArchitectureTemplate.Common;

namespace VerticalSliceArchitectureTemplate.Features.Alertas.Commands.CreateAlerta;

public sealed class CreateAlertaEndpoint : IEndpoint
{
    public static void MapEndpoint(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapPostWithCreatedOpenApi("/alertas", HandleAsync)
            .WithTags(nameof(Alerta));
    }

    public static async Task<IResult> HandleAsync(CreateAlertaRequest request, IAlertaRepository alertaRepository,
        CancellationToken cancellationToken)
    {
        var output = new Alerta
        {
            Texto = request.Texto
        };

        await alertaRepository.AddAsync(output, cancellationToken);

        return Results.Created("/alertas", output.Id);
    }
}