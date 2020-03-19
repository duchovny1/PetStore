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

        public virtual Gender Gender { get; set; }

        public virtual DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

       
        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual  int? BreedId { get; set; }
        public virtual Breed Breed { get; set; }

        public virtual decimal Price { get; set; }

        public virtual int? FoodId { get; set; }
        public virtual Food Food { get; set; }

        public virtual int? OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual ICollection<ToyOrder> Toys { get; set; } = new HashSet<ToyOrder>();
    }
}
