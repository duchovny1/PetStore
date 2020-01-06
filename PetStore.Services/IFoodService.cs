namespace PetStore.Services
{
    using System;
    using PetStore.Services.Models.Food;

    public interface IFoodService
    {
        void BuyFromDistributor(string name, double weigth, decimal price,
            decimal profit,
            DateTime expirationDate, int brandId, int categoryId);

        void BuyFromDistributor(AddingFoodServiceModel model);

        void SellFoodToUser(int foodId, int userId);
    }
}
