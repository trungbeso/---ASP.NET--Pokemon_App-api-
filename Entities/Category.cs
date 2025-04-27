namespace PokemonReviewApp.Api.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    // Many-to-Many relationship with Pokemon (via PokemonCategory join entity)
    // A Category has many Pokemon
    public ICollection<PokemonCategory> PokemonCategories { get; set; } = new List<PokemonCategory>();
}