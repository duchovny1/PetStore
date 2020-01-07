namespace PetStore.Services.Implementations
{
    using System.Linq;
    using PetStore.Data;
    public class CategoryService : ICategoryService
    {
        private readonly PetStoreDbContext data;

        public CategoryService(PetStoreDbContext data)
        {
            this.data = data;
        }
        public bool Exists(int categoryId)
           => this.data.Categories.Any(x => x.Id == categoryId);
    }
}
