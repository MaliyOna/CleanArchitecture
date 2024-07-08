using CleanArchitecture.Enterprise.Abstractions;

namespace CleanArchitecture.Application.Interfaces;
public interface IGenericService<Model> where Model : IBaseModel
{
    Task<Model?> GetById(Guid id, CancellationToken cancellationToken);
    Task<List<Model>> GetAll(CancellationToken cancellationToken);
    Task Create(Model model, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
    Task Update(Model model, CancellationToken cancellationToken);
}
