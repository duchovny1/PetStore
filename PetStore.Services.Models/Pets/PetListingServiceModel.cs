namespace PetStore.Services.Models.Pets
{
    using PetStore.Data.Models;
    using System;

    public class PetListingServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Breed { get; set; }
        public string Category { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
