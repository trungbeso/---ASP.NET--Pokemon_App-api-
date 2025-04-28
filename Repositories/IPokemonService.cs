using PokemonReviewApp.Api.Entities;

namespace PokemonReviewApp.Api.Repositories;

public interface IPokemonService
{
    ICollection<Pokemon> GetAll();
    Pokemon GetById(int id);
    Pokemon GetByName(string name);
    decimal GetRating(int id);
    bool PokemonExists(int id);
}