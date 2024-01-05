using Microsoft.AspNetCore.Routing;

namespace VerticalSliceArchitectureTemplate.Common;

public interface IEndpoint
{
    static abstract void MapEndpoint(IEndpointRouteBuilder endpoints);
}