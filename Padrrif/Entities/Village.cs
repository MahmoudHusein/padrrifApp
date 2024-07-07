namespace Padrrif;

public class Village : BaseEntity
{
    public string Name { get; set; } = null!;
    public Guid GovernorateId { get; set; } // Adding GovernorateId property
    public Governorate Governorate { get; set; } // Navigation property to Governorate

    [JsonIgnore]
    public ICollection<Damage>? Damages { get; set; }
}
