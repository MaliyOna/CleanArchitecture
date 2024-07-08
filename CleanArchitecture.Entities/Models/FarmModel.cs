namespace CleanArchitecture.Enterprise.Models;

public class FarmModel : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<CatModel> Cats { get; set; } = new List<CatModel>();
}
