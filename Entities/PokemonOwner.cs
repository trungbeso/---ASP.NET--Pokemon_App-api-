namespace PokemonReviewApp.Api.Entities;

// Join Entity for Many-to-Many between Pokemon and Owner
public class PokemonOwner
{
    // Composite Primary Key configured in Fluent API
    public int PokemonId { get; set; } // Foreign Key to Pokemon
    public Pokemon Pokemon { get; set; } // Reference Navigation Property

    public int OwnerId { get; set; } // Foreign Key to Owner
    public Owner Owner { get; set; } // Reference Navigation Property
}