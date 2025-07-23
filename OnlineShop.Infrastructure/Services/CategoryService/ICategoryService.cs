using OnlineShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategoryAsync();
        Task AddCategoryAsync(Category category);
        Task<Category> GetCategoryByIdAsync(int id);
        void DeleteCategory(Category category);
        void SaveAsync();

    }
}
