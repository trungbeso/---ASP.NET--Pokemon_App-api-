namespace PokemonReviewApp.Api.Entities;

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    //many-to-one
    public ICollection<Owner> Owners { get; set; }
}