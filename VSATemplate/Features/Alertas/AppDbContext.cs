using Microsoft.EntityFrameworkCore;
using System;
using VerticalSliceArchitectureTemplate.Features.Alertas;

namespace VerticalSliceArchitectureTemplate.Common;

public partial class AppDbContext : DbContext
{
    public DbSet<Alerta> Alertas { get; set; }
}