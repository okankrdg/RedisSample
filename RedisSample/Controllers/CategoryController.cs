using Microsoft.AspNetCore.Mvc;
using RedisSample.Services;

namespace RedisSample.Controllers;

[Route("api")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    [HttpGet("category/getall")]
    public  IActionResult GetAll()
    {
        return Ok(_categoryService.GetAllCategory());
    }
}

