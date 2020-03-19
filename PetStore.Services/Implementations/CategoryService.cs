namespace PetStore.Services.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using PetStore.Data;
    using PetStore.Data.Models;
    using PetStore.Services.Models.Categories;

    public class CategoryService : ICategoryService
    {
        private readonly PetStoreDbContext data;

        public CategoryService(PetStoreDbContext data)
        {
            this.data = data;
        }

        public IEnumerable<GetAllCategoriesViewModel> getAllCategories()
                  => this.data.Categories.Select(x => new GetAllCategoriesViewModel
                  {
                      Id = x.Id,
                      Name = x.Name,
                      Description = x.Description
                  })
                  .ToList();

        public bool Exists(int categoryId)
           => this.data.Categories.Any(x => x.Id == categoryId);

        public void Create(CreateCategoryServiceModel model)
        {
            Category category = new Category
            {
                Name = model.Name,
                Description = model.Description
            };

            this.data.Categories.Add(category);
            this.data.SaveChanges();
        }

        public CategoryDetailsServiceModel GetById(int id)
        {
            var category = this.data.Categories.Find(id);

            var cdsm = new CategoryDetailsServiceModel
            {
                Id = category.Id,
                Name = category?.Name,
                Description = category?.Description
            };

            return cdsm;
        }
                 
    }
}
