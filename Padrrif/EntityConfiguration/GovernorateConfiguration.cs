namespace Padrrif;

public class GovernorateConfiguration : BaseEntityConfiguration<Governorate>
{
    public override void Configure(EntityTypeBuilder<Governorate> builder)
    {
        base.Configure(builder);

        builder.Property(e => e.Name)
               .HasMaxLength(50)
               .IsRequired();

        builder.HasMany(e => e.Users)
               .WithOne(e => e.Governorate)
               .HasForeignKey(e => e.GovernorateId);

        builder.HasMany(g => g.Villages)
               .WithOne(v => v.Governorate)
               .HasForeignKey(v => v.GovernorateId); // Configuring relationship
    }
}
