namespace CleanArchitecture.Web.DTOs;

public class FarmDTO : BaseDTO
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<CatDTO> Cats { get; set; } = new List<CatDTO>();
}
