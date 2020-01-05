namespace PetStore.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PetStore.Data.Models;

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
               .HasMany(x => x.Pets)
               .WithOne(x => x.Category)
               .HasForeignKey(x => x.CategoryId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
            .HasMany(x => x.Food)
            .WithOne(x => x.Category)
            .HasForeignKey(fk => fk.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

            builder
           .HasMany(x => x.Toys)
           .WithOne(x => x.Category)
           .HasForeignKey(fk => fk.CategoryId)
           .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
