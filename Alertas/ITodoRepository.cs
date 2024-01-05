namespace VerticalSliceArchitectureTemplate.Features.Todos;

public interface ITodoRepository
{
    Task<IEnumerable<Todo>> GetAllAsync(bool? isCompleted = null, CancellationToken cancellationToken = default);
    Task<Todo?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Todo> AddAsync(Todo todo, CancellationToken cancellationToken = default);
    Task DeleteAsync(Todo todo, CancellationToken cancellationToken = default);
    Task UpdateAsync(Todo todo, CancellationToken cancellationToken = default);
}
