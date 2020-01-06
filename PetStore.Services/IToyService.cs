namespace PetStore.Services
{
    using PetStore.Services.Models.Toys;
    public interface IToyService
    {
        void BuyFromDistributor(string name, string description, decimal distributorPrice,
            decimal profit, int brandId, int categoryId);

        void BuyFromDistributor(AddingToyServiceModel model);

        void SellToyToUser(int toyId, int userId);

        bool Exists(int toyId);

    }
}
