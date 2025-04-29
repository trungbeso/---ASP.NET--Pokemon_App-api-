using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Api.Dtos;
using PokemonReviewApp.Api.Entities;
using PokemonReviewApp.Api.Repositories;

namespace PokemonReviewApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CountryController : Controller
{
    private readonly ICountryService _service;
    private readonly IMapper _mapper;

    public CountryController(ICountryService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    
    // GET
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Country>))]
    public IActionResult GetCountryList()
    {
        var countryList = _mapper.Map<CountryDto>(_service.GetAll());
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(countryList);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Country>))]
    [ProducesResponseType(404)]
    public IActionResult GetCountry(int id)
    {
        if (!_service.CountryExists(id))
        {
            return NotFound();
        }
        var country = _mapper.Map<CountryDto>(_service.GetById(id));
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        return Ok(country);
    }
    [HttpGet("/owners/{ownerId}")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Country>))]
    [ProducesResponseType(404)]
    public IActionResult GetCountryOfAnOwner(int ownerId)
    {
        var country = _mapper.Map<CountryDto>(_service.GetByOwner(ownerId));
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(country);
    }

    
}