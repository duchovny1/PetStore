namespace PetStore.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataValidation;
    public class Pet
    {
        public int Id { get; set; }


        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

       
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int BreedId { get; set; }
        public Breed Breed { get; set; }

        public decimal Price { get; set; }

        public int FoodId { get; set; }
        public Food Food { get; set; }

        public int? OrderId { get; set; }

        public Order Order { get; set; }
        public ICollection<ToyOrder> Toys { get; set; } = new HashSet<ToyOrder>();
    }
}
