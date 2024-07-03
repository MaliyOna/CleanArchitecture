using CleanArchitecture.Enterprise.Abstractions;

namespace CleanArchitecture.Enterprise.Entities;

public abstract class BaseEntity : IBaseEntity
{
    public Guid Id { get; set; }
}
