namespace PetStore.Services
{
    using PetStore.Services.Models;
    using System;
    using System.Collections.Generic;

    public interface IBrandServices
    {
        int Create(string name);

        IEnumerable<BrandListingServiceModel> SearchByName(string name);

        BrandWithToysServiceModel FindByIdWithToys(int id);
    }
}
