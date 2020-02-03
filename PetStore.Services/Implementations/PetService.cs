namespace PetStore.Services.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using PetStore.Data;
    using PetStore.Data.Models;
    using PetStore.Services.Models.Pets;

    public class PetService : IPetService
    {
        private const int pageSizes = 25;

        private readonly PetStoreDbContext data;
        IBreedService breedService;
        ICategoryService categoryService;
        IUserService userService;

        public PetService(PetStoreDbContext data, IBreedService breedService,
                          ICategoryService categoryService, IUserService userService)
        {
            this.data = data;
            this.breedService = breedService;
            this.categoryService = categoryService;
            this.userService = userService;
        }
        public void BuyPet(Gender gender, DateTime date, decimal price, string description, int breedId, int categoryId)
        {
            if(price <= 0)
            {
                throw new InvalidOperationException("Price cannot be less or equal to zero!");
            }

            if(!this.breedService.Exists(breedId))
            {
                throw new ArgumentException("There is no such breed with the given id in database");
            }

            if (!this.categoryService.Exists(categoryId))
            {
                throw new ArgumentException("There is no such category with the given id in database");
            }

            var pet = new Pet()
            {
                Gender = gender,
                DateOfBirth = date,
                Price = price,
                Description = description,
                BreedId = breedId,
                CategoryId = categoryId
            };

            this.data.Pets.Add(pet);
            this.data.SaveChanges();
        }

        public void SellPet(int petId, int userId)
        {
            if(!this.userService.Exists(userId))
            {
                throw new ArgumentException("There is no such user with the given id in database!");
            }
            if (!Exists(petId))
            {
                throw new ArgumentException("There is no such pet with the given id in database!");
            }

            var pet = this.data.Pets
                .First(p => p.Id == petId);

            var order = new Order
            {
                PurchaseDate = DateTime.Now,
                Status = OrderStatus.Done,
                UserId = userId,
            };

            this.data.Orders.Add(order);
            pet.Order = order;
                
            this.data.SaveChanges();
            
        }

        public bool Exists(int petId)
                => this.data.Pets.Any(x => x.Id == petId);

        public IEnumerable<PetListingServiceModel> All(int page = 1)
        {
            return this.data
                .Pets
                .Skip((page - 1) * pageSizes)
                .Take(pageSizes)
                .Select(p => new PetListingServiceModel
                {
                    Id = p.Id,
                    Price = p.Price,
                    Category = p.Category.Name,
                    Breed = p.Breed.Name
                })
                .ToList();
                
        }

        public int Total() => this.data.Pets.Count();

        public PetDetailsServiceModel Details(int id)
        {
            return this.data.Pets.Where(x => x.Id == id)
                .Select(pet => new PetDetailsServiceModel
                {
                    Id = pet.Id,
                    Breed = pet.Breed.Name,
                    Price = pet.Price
                }).FirstOrDefault();
        }

        public bool Delete(int id)
        {
            var pet = this.data.Pets.Find(id);

            if (pet == null)
            {
                return false;
            }

            this.data.Pets.Remove(pet);
            this.data.SaveChanges();

            return true;

        }
    }
}
