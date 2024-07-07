namespace Padrrif;

public class VillageDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public Guid GovernorateId { get; set; } // Adding GovernorateId property
}
