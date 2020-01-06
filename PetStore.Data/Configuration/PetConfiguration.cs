
namespace PetStore.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PetStore.Data.Models;

    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasOne(b => b.Breed)
                 .WithMany(p => p.Pets)
                 .HasForeignKey(p => p.BreedId)
                 .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(o => o.Order)
                .WithMany(p => p.Pets)
                .HasForeignKey(fk => fk.OrderId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
