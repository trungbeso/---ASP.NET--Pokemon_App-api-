using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Api.Entities;

public class Country
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    
    // One-to-Many relationship with Owner
    // A Country can have many Owners
    public ICollection<Owner> Owners { get; set; } = new List<Owner>();
}