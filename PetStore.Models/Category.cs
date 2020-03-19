using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


using static PetStore.Data.Models.DataValidation;

namespace PetStore.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        public virtual ICollection<Pet> Pets { get; set; } = new HashSet<Pet>();

        public virtual ICollection<Food> Food { get; set; } = new HashSet<Food>();

        public virtual ICollection<Toy> Toys { get; set; } = new HashSet<Toy>();



    }
}
