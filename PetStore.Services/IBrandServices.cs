namespace PetStore.Services
{
    using PetStore.Data.Models;
    using PetStore.Services.Implementations;
    using PetStore.Services.Models;
    using System;
    using System.Collections.Generic;

    public interface IBrandServices
    {
        int Create(string name);

        IEnumerable<BrandListingServiceModel> SearchByName(string name);

        BrandsWithToysService FindByIdWithToys(int id);

        bool Exists(int brandId);
         
    }
}
