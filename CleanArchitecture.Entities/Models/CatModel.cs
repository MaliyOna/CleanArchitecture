using CleanArchitecture.Enterprise.Enums;

namespace CleanArchitecture.Enterprise.Models;

public class CatModel : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public BreedEnum Breed { get; set; }
}
