using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Api.Entities;

// Join Entity for Many-to-Many between Pokemon and Category
public class PokemonCategory
{
    public int PokemonId { get; set; } // Foreign Key to Pokemon
    public Pokemon Pokemon { get; set; } // Reference Navigation Property
    
    public int CategoryId { get; set; } // Foreign Key to Category
    public Category Category { get; set; } // Reference Navigation Property
}