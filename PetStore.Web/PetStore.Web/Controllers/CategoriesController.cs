namespace PetStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PetStore.Services;
    using PetStore.Services.Models.Categories;
    using PetStore.Web.ViewModels;

    public class CategoriesController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateCategoryInputModel model)
        {
            var categoryServiceModel = new CreateCategoryServiceModel()
            {
                Name = model.Name,
                Description = model.Description
            };

            this.categoryService.Create(categoryServiceModel);

            return RedirectToAction(nameof(All));
        }


        public IActionResult All()
        {
            var categories = this.categoryService.getAllCategories();

            return this.View(categories);
        }
        public IActionResult Details(int id)
        {
            var category = this.categoryService.GetById(id);

            if(category.Name == null)
            {
                return BadRequest();
            }

            CategoryDetailViewModel viewModel = new CategoryDetailViewModel()
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };

            return this.View(viewModel);
        }


        public IActionResult Edit(int id)
        {
            var category = this.categoryService.GetById(id);

            if (category.Name == null)
            {
                return BadRequest();
            }

            var viewModel = new CategoryDetailViewModel()
            {
                Name = category.Name,
                Description = category.Description
            };

            return this.View(viewModel);
        }
    }
}