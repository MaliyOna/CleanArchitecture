using CleanArchitecture.Enterprise.Abstractions;

namespace CleanArchitecture.Application.Interfaces;

public interface IGenericRepository<Entity> where Entity: IBaseEntity
{
    Task<Entity?> GetById(Guid id, CancellationToken cancellationToken);
    Task<List<Entity>> GetAll(CancellationToken cancellationToken);
    Task Create(Entity entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
    Task Update(Entity entity, CancellationToken cancellationToken);
}
