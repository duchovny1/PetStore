using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetStore.Data.Models
{
    using static DataValidation;
    public class Toy
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }


        public decimal DistributorPrice { get; set; }

        public decimal Price { get; set; }

        public virtual int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual int PetId { get; set; }

        public virtual Pet Pet { get; set; }

        public virtual int CategoryId { get; set; }



        public virtual Category Category { get; set; }
        public virtual ICollection<ToyOrder> ToyOrders { get; set; } = new HashSet<ToyOrder>();

    }
}
