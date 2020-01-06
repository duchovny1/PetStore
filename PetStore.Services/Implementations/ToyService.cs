namespace PetStore.Services.Implementations
{
    using PetStore.Data;
    using PetStore.Data.Models;
    using PetStore.Services.Models.Toys;
    using System;
    using System.Linq;

    public class ToyService : IToyService
    {
        private readonly PetStoreDbContext data;
        private readonly IUserService userService;

        public ToyService(PetStoreDbContext data, IUserService userService)
        {
            this.data = data;
            this.userService = userService;
        }

        public void BuyFromDistributor(string name, string description, decimal distributorPrice, decimal profit,
        int brandId, int categoryId)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace!");
            }

            //if profit is more thant 500 %
            if(profit < 0 || profit > 5)
            {
                throw new ArgumentException("Profit must be between 0 and 500%!");
            }

            var toy = new Toy
            {
                Name = name,
                Description = description,
                DistributorPrice = distributorPrice,
                Price = distributorPrice + (distributorPrice * profit),
                BrandId = brandId,
                CategoryId = categoryId
            };

            this.data.Toys.Add(toy);
            this.data.SaveChanges();
        }

        public void BuyFromDistributor(AddingToyServiceModel model)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                throw new ArgumentException("Name cannot be null or whitespace!");
            }

            //if profit is more thant 500 %
            if (model.Profit < 0 || model.Profit > 5)
            {
                throw new ArgumentException("Profit must be between 0 and 500%!");
            }

            var toy = new Toy
            {
                Name = model.Name,
                Description = model.Description,
                DistributorPrice = model.DistributorPrice,
                Price = model.DistributorPrice + (model.DistributorPrice * model.Profit),
                BrandId = model.BrandId,
                CategoryId = model.CategoryId
            };

            this.data.Toys.Add(toy);
            this.data.SaveChanges();
        }

        public bool Exists(int toyId)
                  => this.data.Toys.Any(x => x.Id == toyId);

        public void SellToyToUser(int toyId, int userId)
        {
            if(!Exists(toyId))
            {
                throw new ArgumentException("There is no such toy with the given id in the database!");
            }

            if(!this.userService.Exists(userId))
            {
                throw new ArgumentException("There is no such user with the given id in the database!");
            }


            var order = new Order()
            {
                PurchaseDate = DateTime.Now,
                Status = OrderStatus.Done,
                UserId = userId
            };

            var toyOrder = new ToyOrder()
            {
                ToyId = toyId,
                Order = order
            };

            this.data.Orders.Add(order);
            this.data.ToyOrders.Add(toyOrder);
            this.data.SaveChanges();
        }
    }
}
