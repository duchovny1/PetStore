using PetStore.Data;
using PetStore.Data.Models;
using System.Threading.Tasks;

namespace PetStore.Web
{
    public class Seeder
    {
        private readonly PetStoreDbContext db;

        public Seeder(PetStoreDbContext db)
        {
            this.db = db;
            this.db.Database.EnsureCreated();
        }
        internal async Task SeedAsync()
        {
            for (int i = 0; i < 20; i++)
            {
                Breed breed = new Breed();

                breed.Name = $"Breed {i}";

                await this.db.AddAsync(breed);
            }

            this.db.SaveChanges();
        }
    }
}
