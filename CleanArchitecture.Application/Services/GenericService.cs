using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Enterprise.Abstractions;
using CleanArchitecture.Enterprise.Entities;
using CleanArchitecture.Enterprise.Models;

namespace CleanArchitecture.Application.Services;

public class GenericService<Model, Entity> : IGenericService<Model> 
    where Model : BaseModel, new()
    where Entity : class, IBaseEntity, new()
{
    private readonly IGenericRepository<Entity> _genericRepository;

    public GenericService(IGenericRepository<Entity> genericRepository)
    {
        _genericRepository = genericRepository;
    }

    public async Task Create(Model model, CancellationToken cancellationToken)
    {
        var entity = new Entity
        {
            Id = model.Id
        };

        await _genericRepository.Create(entity, cancellationToken);
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        await _genericRepository.Delete(id, cancellationToken);
    }

    public async Task<List<Model>> GetAll(CancellationToken cancellationToken)
    {
        var result = await _genericRepository.GetAll(cancellationToken);

        return result.Select(x => new Model { Id = x.Id }).ToList();
    }

    public async Task<Model?> GetById(Guid id, CancellationToken cancellationToken)
    {
        var result = await _genericRepository.GetById(id, cancellationToken);

        if (result == null)
            throw new Exception();

        return new Model
        {
            Id = result.Id
        };
    }

    public async Task Update(Model model, CancellationToken cancellationToken)
    {
        var entity = new Entity { Id = model.Id };

        await _genericRepository.Update(entity, cancellationToken);
    }
}
