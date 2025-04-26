namespace PokemonReviewApp.Api.Entities;

public class Review
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    
    //many-to-one
    public ICollection<Review> Reviews { get; set; }
    
    //one-to-many
    public Reviewer Reviewer { get; set; }
    public Pokemon Pokemon { get; set; }
}