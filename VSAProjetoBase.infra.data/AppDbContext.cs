using Microsoft.EntityFrameworkCore;

namespace VSAProjetoBase.Common;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}