using System.ComponentModel.DataAnnotations;
using VerticalSliceArchitectureTemplate.Common;

namespace VerticalSliceArchitectureTemplate.Features.Alertas;

public class Alerta : BaseEntity
{
    public Guid Id { get; init; }

    public string Texto { get; set; } = string.Empty;
}