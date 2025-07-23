using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Application;
using OnlineShop.Domain;
using OnlineShop.Infrastructure;

namespace OnlineShop.Presentation.Controllers
{
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    //[ApiVersion("1.0")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _category;
        public CategoryController(ICategoryService category)
        {
            _category = category;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _category.GetCategoryAsync();

            // mappint domain to dto
            var result = categories.Select(c => new CategoryDto
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostCategories(CreateCategoryDto category)
        {

            // mapping dto to entity
            var result = new Category
            {                
                Name = category.Name
            };

            await _category.AddCategoryAsync(result);
            _category.SaveAsync();

            var resultDto = new CategoryDto
            {
                Id = result.Id,
                Name = result.Name
            };
            return CreatedAtAction(nameof(GetCategories), new { id = resultDto.Id }, resultDto);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int Id)
        {
            var category = await _category.GetCategoryByIdAsync(Id);
            _category.DeleteCategory(category);
            _category.SaveAsync();

            return Ok(category.Name +  " has been deleted");
        }
        
    }
}
