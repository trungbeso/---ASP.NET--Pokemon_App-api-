using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonReviewApp.Api.Entities;

public class Review
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    
    // Many-to-One relationship with Reviewer (the author of the review)
    // A Review is written by one Reviewer
    public int ReviewerId { get; set; } // Foreign Key
    [InverseProperty("AuthoredReviews")] // This review is one of the reviews authored by the Reviewer
    public Reviewer Author { get; set; } // Reference Navigation Property for the author
    
    // Many-to-One relationship with Pokemon
    // A Review belongs to one Pokemon
    public int PokemonId { get; set; } // Foreign Key
    public Pokemon Pokemon { get; set; } // Reference Navigation Property
}