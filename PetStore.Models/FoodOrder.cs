namespace PetStore.Data.Models
{
    public class FoodOrder
    {
        public virtual int FoodId { get; set; }

        public virtual Food Food { get; set; }

        public virtual int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
