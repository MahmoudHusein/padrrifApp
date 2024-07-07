namespace Padrrif;

public class Governorate : BaseEntity
{
    public string Name { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<User>? Users { get; set; }

    [JsonIgnore]
    public virtual ICollection<Village>? Villages { get; set; } // Adding Villages collection
}
