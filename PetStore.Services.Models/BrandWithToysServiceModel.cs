using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore.Services.Models
{
    public class BrandWithToysServiceModel
    {
        public string Name { get; set; }

        public IEnumerable<ToyListingServiceModel> Toys { get; set; } = new HashSet<ToyListingServiceModel>();
    }
}
