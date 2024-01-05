using Microsoft.EntityFrameworkCore;
using System;
using VerticalSliceArchitectureTemplate.Features.Alertas;

namespace VerticalSliceArchitectureTemplate.Common;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}