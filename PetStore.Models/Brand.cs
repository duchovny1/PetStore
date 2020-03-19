namespace PetStore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Brand
    {
        public int Id { get; set; }

        [Required]
        [MaxLength]

        public string Name { get; set; }

        public virtual ICollection<Food> Food { get; set; } = new HashSet<Food>();
        public virtual ICollection<Toy> Toys { get; set; } = new HashSet<Toy>();

    }
}
