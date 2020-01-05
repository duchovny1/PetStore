namespace PetStore.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PetStore.Data.Models;

    public class FoodOrderConfiguration : IEntityTypeConfiguration<FoodOrder>
    {
        public void Configure(EntityTypeBuilder<FoodOrder> builder)
        {
            builder
                .HasKey(fo => new { fo.FoodId, fo.OrderId });

            builder
                .HasOne(fo => fo.Food)
                .WithMany(fo => fo.FoodOrders)
                .HasForeignKey(fk => fk.FoodId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(fo => fo.Order)
               .WithMany(fo => fo.Orders)
               .HasForeignKey(fk => fk.OrderId)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
