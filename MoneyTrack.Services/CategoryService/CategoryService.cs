using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories.CategoriesRepository;
using System.Collections.Generic;

namespace MoneyTrack.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public Category Create(Category category)
        {
            return categoryRepository.Create(category);
        }

        public List<Category> Get()
        {
            return categoryRepository.Get();
        }

        public Category Get(string id)
        {
            return categoryRepository.Get(id);
        }

        public bool Remove(Category category)
        {
            return categoryRepository.Remove(category);
        }

        public bool Remove(string id)
        {
            return categoryRepository.Remove(id);
        }

        public bool Update(string id, Category category)
        {
            return categoryRepository.Update(id, category);

        }
    }
}
