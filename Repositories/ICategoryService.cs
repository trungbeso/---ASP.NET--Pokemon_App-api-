using System.Collections;
using PokemonReviewApp.Api.Entities;

namespace PokemonReviewApp.Api.Repositories;

public interface ICategoryService
{
    ICollection<Category> GetAll();
    Category GetById(int id);
    ICollection<Pokemon> GetPokemonByCategory(int categoryId);
    bool CategoryExists(int categoryId);
}