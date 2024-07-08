using CleanArchitecture.Enterprise.Enums;

namespace CleanArchitecture.Web.DTOs;

public class CatDTO : BaseDTO
{
    public string Name { get; set; } = string.Empty;
    public BreedEnum Breed { get; set; }
}
