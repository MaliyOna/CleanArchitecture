using CleanArchitecture.Enterprise.Enums;

namespace CleanArchitecture.Enterprise.Entities;

public class CatEntity : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public BreedEnum Breed { get; set; }
}
