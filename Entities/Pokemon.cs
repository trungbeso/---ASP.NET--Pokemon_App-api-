namespace PokemonReviewApp.Api.Entities;

public class Pokemon
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime BirthDate { get; set; }
    
    //many-to-one
    public ICollection<Review> Reviews { get; set; }
}