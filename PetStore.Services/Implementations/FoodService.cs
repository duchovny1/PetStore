namespace PetStore.Services.Implementations
{
    using System;
    using System.Linq;
    using PetStore.Data;
    using PetStore.Data.Models;
    using PetStore.Services.Models.Food;
    public class FoodService : IFoodService
    {
        private readonly PetStoreDbContext data;
        private readonly IUserService userService;

        public FoodService(PetStoreDbContext data, IUserService userService)
        {
            this.data = data;
            this.userService = userService;
        }

        public void BuyFromDistributor(string name, double weigth, decimal profit,
            decimal price, DateTime expirationDate, int brandId, int categoryId)
        {

            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace!");
            }


            //if profit is more than 500 %
            if(profit < 0 || profit > 5)
            {
                throw new ArgumentException("Profit should be between 0 and 500 procent!");
            }


            var food = new Food
            {
                Name = name,
                Weight = weigth,
                DistributorPrice = price,
                Price = price + (price * profit),
                ExpirationDate = expirationDate,
                BrandId = brandId,
                CategoryId = categoryId

            };

            this.data.Add(food);
            this.data.SaveChanges();
        }

        public void BuyFromDistributor(AddingFoodServiceModel model)
        {

            if (String.IsNullOrEmpty(model.Name))
            {
                throw new ArgumentException("Name cannot be null or whitespace!");
            }


            //if profit is more than 500 %
            if (model.Profit < 0 || model.Profit > 5)
            {
                throw new ArgumentException("Profit should be between 0 and 500 procent!");
            }

            var food = new Food
            {
                Name = model.Name,
                Weight = model.Weight,
                DistributorPrice = model.Price,
                Price = model.Price + (model.Price * model.Profit),
                BrandId = model.BrandId,
                CategoryId = model.CategoryId
            };

            this.data.Add(food);
            this.data.SaveChanges();
        }

        public void SellFoodToUser(int foodId, int userId)
        {
            if(!this.data.Foods.Any(f => f.Id == foodId))
            {
                throw new ArgumentException("There is no such food with given id in database!");
            }

            if(!this.userService.Exists(userId))
            {
                throw new ArgumentException("There is no such user with given id in database!");
            }

            var order = new Order()
            {
                PurchaseDate = DateTime.Now,
                Status = OrderStatus.Done,
                UserId = userId
            };

            var foodOrder = new FoodOrder()
            {
                FoodId = foodId,
                OrderId = order.Id,
            };


            this.data.Orders.Add(order);
            this.data.FoodOrders.Add(foodOrder);
        }
    }
}
