namespace PetStore.Services
{
    using PetStore.Services.Models.Categories;
    using System.Collections.Generic;
    public interface ICategoryService 
    {
        //void Add(string name);

        CategoryDetailsServiceModel GetById(int id);
        bool Exists(int categoryId);

        IEnumerable<GetAllCategoriesViewModel> getAllCategories();

        void Create(CreateCategoryServiceModel model);
    }
}
