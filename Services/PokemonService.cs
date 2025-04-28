using PokemonReviewApp.Api.Data;
using PokemonReviewApp.Api.Entities;
using PokemonReviewApp.Api.Repositories;

namespace PokemonReviewApp.Api.Services;

public class PokemonService : IPokemonService
{

    private readonly DataContext _context;

    public PokemonService(DataContext context)
    {
        _context = context;
    }
    
    public ICollection<Pokemon> GetAll()
    {
        return _context.Pokemon.OrderBy(p => p.Name).ToList();
    }

    public Pokemon GetById(int id)
    {
        return _context.Pokemon.Where(p => p.Id == id).FirstOrDefault();
    }

    public Pokemon GetByName(string name)
    {
        return _context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
    }

    public decimal GetRating(int id)
    {
        var review = _context.Reviews.Where(p => p.Pokemon.Id == id);
        if (review.Count() <= 0)
        {
            return 0;
        }
        return ((decimal)review.Sum(r => r.Rating) / review.Count());
    }

    public bool PokemonExists(int id)
    {
        return _context.Pokemon.Any(p => p.Id == id);
    }
}