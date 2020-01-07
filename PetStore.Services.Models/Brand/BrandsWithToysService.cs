namespace PetStore.Services.Models
{ 
    using System.Collections.Generic;
    public class BrandsWithToysService
    {
        public string Name { get; set; }

        public IEnumerable<ToyListingServiceModel> Toys { get; set; }
    }
}
