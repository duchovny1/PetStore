namespace PetStore.Services.Models.Breed
{
    using PetStore.Services.Models.Pets;
    using System.Collections.Generic;
    public class BreedListingServiceModel
    {
        public string Name { get; set; }

        public IEnumerable<PetListingServiceModel> Pets { get; set; }
    }
}
