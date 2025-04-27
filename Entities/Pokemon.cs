namespace PokemonReviewApp.Api.Entities;

public class Pokemon
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime BirthDate { get; set; }
    
    // one-to-many relationshop
    // a pokemon can have many reviews
    public ICollection<Review> Reviews { get; set; }
    
    // Many-to-Many relationship with Owner (via PokemonOwner join entity)
    // A Pokemon can have many Owners
    public ICollection<PokemonOwner> PokemonOwners { get; set; } = new List<PokemonOwner>();
    
    // Many-to-Many relationship with Category (via PokemonCategory join entity)
    // A Pokemon belongs to many Categories
    public ICollection<PokemonCategory> PokemonCategories { get; set; }
}