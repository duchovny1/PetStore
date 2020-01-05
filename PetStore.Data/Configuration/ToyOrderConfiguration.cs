namespace PetStore.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PetStore.Data.Models;

    public class ToyOrderConfiguration : IEntityTypeConfiguration<ToyOrder>
    {
        public void Configure(EntityTypeBuilder<ToyOrder> builder)
        {
            builder
                .HasKey(fo => new { fo.ToyId, fo.OrderId });

            builder
                .HasOne(fo => fo.Toy)
                .WithMany(fo => fo.ToyOrders)
                .HasForeignKey(fk => fk.ToyId)
                ;

            builder
               .HasOne(fo => fo.Order)
               .WithMany(fo => fo.ToyOders)
               .HasForeignKey(fk => fk.OrderId)
               ;
        }
    }
}
