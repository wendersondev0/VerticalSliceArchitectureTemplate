using Microsoft.EntityFrameworkCore;
using VerticalSliceArchitectureTemplate.Common;

namespace VerticalSliceArchitectureTemplate.Features.Alertas;

public interface IAlertaRepository
{
    Task<IEnumerable<Alerta>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Alerta?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Alerta> AddAsync(Alerta alerta, CancellationToken cancellationToken = default);
    Task DeleteAsync(Alerta alerta, CancellationToken cancellationToken = default);
    Task UpdateAsync(Alerta alerta, CancellationToken cancellationToken = default);
}

public class AlertaRepository : IAlertaRepository
{
    private readonly AppDbContext _appDbContext;

    public AlertaRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<IEnumerable<Alerta>> GetAllAsync(
        CancellationToken cancellationToken = default)
    {
        var query = _appDbContext.Alertas.AsQueryable();

        return await query.ToListAsync(cancellationToken);
    }

    public async Task<Alerta?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _appDbContext.Alertas.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<Alerta> AddAsync(Alerta alerta, CancellationToken cancellationToken = default)
    {
        _appDbContext.Alertas.Add(alerta);
        await _appDbContext.SaveChangesAsync(cancellationToken);
        return alerta;
    }

    public async Task DeleteAsync(Alerta alerta, CancellationToken cancellationToken = default)
    {
        _appDbContext.Alertas.Remove(alerta);
        await _appDbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(Alerta alerta, CancellationToken cancellationToken = default)
    {
        _appDbContext.Alertas.Update(alerta);
        await _appDbContext.SaveChangesAsync(cancellationToken);
    }
}