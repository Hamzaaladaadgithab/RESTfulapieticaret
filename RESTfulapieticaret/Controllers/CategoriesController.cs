using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTfulapieticaret.Data;
using Microsoft.EntityFrameworkCore;
using RESTfulapieticaret.Data.Models;

namespace RESTfulapieticaret.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class CategoriesController : ControllerBase
    {

public CategoriesController(AppDbContext db)
    {
            _db = db;
        }   

        private readonly AppDbContext _db;


        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _db.Categories.ToListAsync();
            return Ok(categories);
        }


        [HttpPost]
        public async Task<IActionResult> AddCategories([FromBody] Category category)
        {
            if (category == null || string.IsNullOrEmpty(category.Name))
            {
                return BadRequest("Category name is required.");
            }

            // لا حاجة لسطر Category c = new()... 
            // أضف الكائن القادم في البارامتر مباشرة
            _db.Categories.Add(category);

            await _db.SaveChangesAsync();
            return Ok(category);
        }


    }
}
