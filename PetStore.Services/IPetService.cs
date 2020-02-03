using PetStore.Data.Models;
using PetStore.Services.Models.Pets;
using System;
using System.Collections.Generic;

namespace PetStore.Services
{
    public interface IPetService
    {
        void BuyPet(Gender gender, DateTime date, decimal price, string description,
            int breedId, int categoryId);

        void SellPet(int userId, int petId);

        IEnumerable<PetListingServiceModel> All(int page = 1);

        int Total();

        PetDetailsServiceModel Details(int id);
        bool Delete(int id);
    }

}
