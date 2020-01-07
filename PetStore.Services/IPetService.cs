using PetStore.Data.Models;
using System;

namespace PetStore.Services
{
    public interface IPetService
    {
        void BuyPet(Gender gender, DateTime date, decimal price, string description,
            int breedId, int categoryId);

        void SellPet(int userId, int petId);
    }
}
