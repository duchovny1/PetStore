namespace PetStore.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataValidation;
    public class Food
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public DateTime ExpirationDate { get; set; }
        public virtual int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public double Weight { get; set; }

        public decimal DistributorPrice { get; set; }
        public decimal Price { get; set; }

        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Pet> Pets { get; set; } = new HashSet<Pet>();

        public virtual ICollection<FoodOrder> FoodOrders { get; set; } = new HashSet<FoodOrder>();
    }
}
