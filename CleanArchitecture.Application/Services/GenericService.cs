using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Enterprise.Abstractions;
using MapsterMapper;

namespace CleanArchitecture.Application.Services;

public class GenericService<Model, Entity> : IGenericService<Model>
    where Entity : IBaseEntity
{
    private readonly IMapper _mapper;
    private readonly IGenericRepository<Entity> _genericRepository;

    public GenericService(IMapper mapper, IGenericRepository<Entity> genericRepository)
    {
        _mapper = mapper;
        _genericRepository = genericRepository;
    }

    public async Task Create(Model model, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Entity>(model);

        await _genericRepository.Create(entity, cancellationToken);
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        await _genericRepository.Delete(id, cancellationToken);
    }

    public async Task<List<Model>> GetAll(CancellationToken cancellationToken)
    {
        var result = await _genericRepository.GetAll(cancellationToken);

        return _mapper.Map<List<Model>>(result);
    }

    public async Task<Model?> GetById(Guid id, CancellationToken cancellationToken)
    {
        var result = await _genericRepository.GetById(id, cancellationToken);

        if (result == null)
            throw new Exception();

        return _mapper.Map<Model?>(result);
    }

    public async Task Update(Model model, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Entity>(model);

        await _genericRepository.Update(entity, cancellationToken);
    }
}
