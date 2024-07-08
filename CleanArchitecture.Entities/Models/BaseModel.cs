using CleanArchitecture.Enterprise.Abstractions;

namespace CleanArchitecture.Enterprise.Models;

public class BaseModel : IBaseModel
{
    public Guid Id { get; set; }
}
