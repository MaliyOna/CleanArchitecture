using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Enterprise.Entities;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;

namespace CleanArchitecture.Infrastructure.Repositories;
public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : BaseEntity
{
    protected readonly ApplicationDbContext dbContext;
    protected readonly DbSet<Entity> dbSet;

    public GenericRepository(ApplicationDbContext applicationDbContext)
    {
        dbContext = applicationDbContext;
        dbSet = applicationDbContext.Set<Entity>();
    }

    public async Task Create(Entity entity, CancellationToken cancellationToken)
    {
        await dbSet.AddAsync(entity, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        await dbSet.Where(x => x.Id == id).DeleteAsync(cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<List<Entity>> GetAll(CancellationToken cancellationToken)
    {
        return await dbSet.ToListAsync(cancellationToken);
    }

    public async Task<Entity?> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await dbSet.Where(x => x.Id == id).FirstOrDefaultAsync(cancellationToken);
    }

    public async Task Update(Entity entity, CancellationToken cancellationToken)
    {
        dbContext.Entry(entity).State = EntityState.Modified;
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}
