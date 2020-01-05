namespace PetStore.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PetStore.Data.Models;

    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {

            builder
            .HasMany(f => f.Food)
            .WithOne(b => b.Brand)
            .HasForeignKey(fk => fk.BrandId);

            builder
            .HasMany(f => f.Toys)
            .WithOne(b => b.Brand)
            .HasForeignKey(fk => fk.BrandId);
        }
    }
}
