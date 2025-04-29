using PokemonReviewApp.Api.Entities;

namespace PokemonReviewApp.Api.Repositories;

public interface ICountryService
{
    ICollection<Country> GetAll();
    Country GetById(int id);
    Country GetByOwner(int ownerId);
    ICollection<Owner> GetOwnerListFromCountry(int countryId);
    bool CountryExists(int id);
}