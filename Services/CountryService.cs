using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Api.Data;
using PokemonReviewApp.Api.Entities;
using PokemonReviewApp.Api.Repositories;

namespace PokemonReviewApp.Api.Services;

public class CountryService : ICountryService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public CountryService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public ICollection<Country> GetAll()
    {
        return _context.Countries.OrderBy(c => c.Name).ToList();
    }

    public Country GetById(int id)
    {
        return _context.Countries
            .Where(c => c.Id == id)
            .FirstOrDefault();
    }

    public Country GetByOwner(int ownerId)
    {
        return _context.Owners.Where(o => o.Id == ownerId).Select(c => c.Country).FirstOrDefault();
    }

    public ICollection<Owner> GetOwnerListFromCountry(int countryId)
    {
        return _context.Owners.Where(o => o.CountryId == countryId).ToList();
    }

    public bool CountryExists(int id)
    {
        return _context.Countries.Any(e => e.Id == id);
    }
}