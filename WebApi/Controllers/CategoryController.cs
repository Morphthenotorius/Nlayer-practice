using Business.Abstract;
using Entities.DTOs.CategoryDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public IActionResult Create(CreateCategoryDTO model)
        {
            _categoryService.CreateCategory(model);
            return Ok();
        }
    }
}
