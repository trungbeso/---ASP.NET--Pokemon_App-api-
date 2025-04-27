using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonReviewApp.Api.Entities;

public class Reviewer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    // One-to-Many relationship with Review (Authored reviews)
    // A Reviewer can author many Reviews
    // Adding [InverseProperty] here and on Review to demonstrate clarifying relationships
    [InverseProperty("Author")] // These are the reviews where this Reviewer is the Author
    public ICollection<Review> AuthoredReviews { get; set; } = new List<Review>();
}