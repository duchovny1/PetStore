namespace PetStore.Data.Models
{
    public class ToyOrder
    {
        public virtual int ToyId { get; set; }

        public virtual Toy Toy { get; set; }

        public virtual int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
