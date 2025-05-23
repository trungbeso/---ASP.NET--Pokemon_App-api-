﻿using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Api.Entities;

public class Owner
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gym { get; set; }
    
    // Many-to-One relationship with Country
    // An Owner is from one Country
    public int CountryId { get; set; } // Foreign Key
    public Country Country { get; set; } // Reference Navigation Property
    
    // Many-to-Many relationship with Pokemon (via PokemonOwner join entity)
    // An Owner owns many Pokemon
    public ICollection<PokemonOwner> PokemonOwners { get; set; } = new List<PokemonOwner>();
}