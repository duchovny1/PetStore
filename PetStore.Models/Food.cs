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
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public double Weight { get; set; }

        public decimal DistributorPrice { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Pet> Pets { get; set; } = new HashSet<Pet>();

        public ICollection<FoodOrder> FoodOrders { get; set; } = new HashSet<FoodOrder>();
    }
}
