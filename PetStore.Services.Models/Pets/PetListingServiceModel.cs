namespace PetStore.Services.Models.Pets
{
    using PetStore.Data.Models;
    using System;

    public class PetListingServiceModel
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
