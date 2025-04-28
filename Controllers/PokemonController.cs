using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Api.Dtos;
using PokemonReviewApp.Api.Entities;
using PokemonReviewApp.Api.Repositories;
using PokemonReviewApp.Api.Services;

namespace PokemonReviewApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokemonController : Controller
{
    
    private readonly IPokemonService _service;
    private readonly IMapper _mapper;

    public PokemonController(IPokemonService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    
    // GET
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
    public IActionResult GetPokemonList()
    {
        var pokemonList = _mapper.Map<PokemonDto>(_service.GetAll());
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(pokemonList);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(200, Type = typeof(Pokemon))]
    [ProducesResponseType(404)]
    public IActionResult GetPokemon(int id)
    {
        if (!_service.PokemonExists(id))
        {
            return NotFound();
        }
        var pokemon = _mapper.Map<PokemonDto>(_service.GetById(id));
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        return Ok(pokemon);
    }

    [HttpGet("{id}/ratings")]
    [ProducesResponseType(200, Type = typeof(decimal))]
    [ProducesResponseType(404)]
    public IActionResult GetPokemonRating(int id)
    {
        if (!_service.PokemonExists(id))
        {
            return NotFound();
        }
        var rating = _service.GetRating(id);
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(rating);
    }
    
    
}