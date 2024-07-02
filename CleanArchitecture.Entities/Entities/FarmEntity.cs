namespace CleanArchitecture.Enterprise.Entities;

public class FarmEntity : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<CatEntity> Cats { get; set; } = new List<CatEntity>();
}
