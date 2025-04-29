using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Api.Dtos;
using PokemonReviewApp.Api.Entities;
using PokemonReviewApp.Api.Repositories;

namespace PokemonReviewApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : Controller
{
    private readonly ICategoryService _service;
    private readonly IMapper _mapper;

    public CategoryController(ICategoryService categoryService, IMapper mapper)
    {
        _service = categoryService;
        _mapper = mapper;
    }
    
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
    public IActionResult GetCategories()
    {
        var categories = _mapper.Map<CategoryDto>(_service.GetAll());
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(categories);
    }
    
    [HttpGet("{categoryId}")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
    [ProducesResponseType(404)]
    public IActionResult GetCategoryById(int categoryId)
    {
        if (!_service.CategoryExists(categoryId))
        {
            return NotFound();
        }
        var category = _mapper.Map<CategoryDto>(_service.GetById(categoryId));
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        return Ok(category);
    }

    [HttpGet("pokemon/{categoryId}")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
    [ProducesResponseType(404)]
    public IActionResult GetPokemonByCategoryId(int categoryId)
    {
        var pokemons = _mapper.Map<List<PokemonDto>>(_service.GetPokemonByCategory(categoryId));

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(pokemons);
    }
    
    
}