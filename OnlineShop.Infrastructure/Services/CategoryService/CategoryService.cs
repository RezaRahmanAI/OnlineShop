using OnlineShop.Application;
using OnlineShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineShop.Infrastructure
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _appDbContext;

        public CategoryService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddCategoryAsync(Category category)
            => await _appDbContext.AddAsync(category);

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            var category = await _appDbContext.Categories.FindAsync(id);
            // if (category == null)
            //     return null;
            return category;
        }

        public void DeleteCategory(Category category)
        {
            _appDbContext.Categories.Remove(category);
        }

        public async Task<IEnumerable<Category>> GetCategoryAsync()
        {
            var categories = await _appDbContext.Categories.ToListAsync();

            return categories;
        }

        public void SaveAsync()
        {
            _appDbContext.SaveChanges();
        }

    }
}
