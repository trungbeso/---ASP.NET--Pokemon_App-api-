using PokemonReviewApp.Api.Data;
using PokemonReviewApp.Api.Entities;
using PokemonReviewApp.Api.Repositories;

namespace PokemonReviewApp.Api.Services;

public class CategoryService : ICategoryService
{
    
    private readonly DataContext _context;

    public CategoryService(DataContext context)
    {
        _context = context;
    }
    
    public ICollection<Category> GetAll()
    {
        return _context.Categories.ToList();
    }

    public Category GetById(int id)
    {
        return _context.Categories
            .Where(c => c.Id == id)
            .FirstOrDefault();
    }

    public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
    {
        return _context.PokemonCategories
            .Where(e => e.CategoryId == categoryId)
            .Select(c => c.Pokemon)
            .ToList();
    }

    public bool CategoryExists(int categoryId)
    {
        return _context.Categories.Any(c => c.Id == categoryId);
    }
}