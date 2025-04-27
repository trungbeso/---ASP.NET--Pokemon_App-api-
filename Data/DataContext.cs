using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Api.Entities;

namespace PokemonReviewApp.Api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Pokemon> Pokemon { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Reviewer> Reviewers { get; set; }
    public DbSet<PokemonCategory> PokemonCategories { get; set; }
    public DbSet<PokemonOwner> PokemonOwners { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // ! Pokemon (Many) to Category (Many) via PokemonCategory
        modelBuilder.Entity<PokemonCategory>()
            .HasKey(pc => new { pc.PokemonId, pc.CategoryId }); //? Define the composite primary key
        
        // ! Relationship from PokemonCategory to Pokemon
        modelBuilder.Entity<PokemonCategory>()
            //*  PokemonCategory has 'one' Pokemon
            .HasOne(p => p.Pokemon)
            //* Pokemon has 'many' PokemonCategories
            .WithMany(pc => pc.PokemonCategories)
            //* The FK in PokemonCategory pointing to Pokemon
            .HasForeignKey(c => c.PokemonId)
            //* If a Pokemon is deleted, delete the linking entry in PokemonCategory
            .OnDelete(DeleteBehavior.Cascade);
        
        // ! Relationship from PokemonCategory to Category
        // ? same as above
        modelBuilder.Entity<PokemonCategory>()
            .HasOne(p => p.Category)
            .WithMany(pc => pc.PokemonCategories)
            .HasForeignKey(c => c.CategoryId);
        
// * ===================================================================================================== *        

        // ! Pokemon (Many) to Owner (Many) via PokemonOwner
        modelBuilder.Entity<PokemonOwner>()
            .HasKey(po => new { po.PokemonId, po.OwnerId }); // ? Define the composite primary key
        
        // ! Relationship from PokemonOwner to Pokemon
        modelBuilder.Entity<PokemonOwner>()
            //*  PokemonCategory has 'one' Pokemon
            .HasOne(po => po.Pokemon)
            //* Pokemon has 'many' PokemonCategories
            .WithMany(p => p.PokemonOwners)
            //* The FK in PokemonCategory pointing to Pokemon
            .HasForeignKey(c => c.PokemonId)
            //* If a Pokemon is deleted, delete the linking entry in PokemonCategory
            .OnDelete(DeleteBehavior.Cascade);
        
        // ! Relationship from PokemonCategory to Category
        // ? same as above
        modelBuilder.Entity<PokemonOwner>()
            .HasOne(p => p.Owner)
            .WithMany(pc => pc.PokemonOwners)
            .HasForeignKey(c => c.PokemonId)
            .OnDelete(DeleteBehavior.Cascade);
        
// * ===================================================================================================== *

        //! Pokemon (one) to Reviews (many)
        //? Config the 'one' side (principal)
        modelBuilder.Entity<Pokemon>()
            .HasMany(p => p.Reviews)
            .WithOne(r => r.Pokemon)
            .HasForeignKey(r => r.PokemonId)
            //? if a Pokemon is deleted -> all its associated reviews will also be deleted
            .OnDelete(DeleteBehavior.Cascade);
        
// * ===================================================================================================== *
        //! country (one) to owner (many)
        modelBuilder.Entity<Country>()
            .HasMany(c => c.Owners)
            .WithOne(o => o.Country)
            .HasForeignKey(o => o.CountryId)
            .IsRequired();
        
// * ===================================================================================================== *        
        //! reviewer (one) to reviews (many)
        modelBuilder.Entity<Reviewer>()
            .HasMany(rv => rv.AuthoredReviews)
            .WithOne(r => r.Author)
            .HasForeignKey(r => r.ReviewerId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
        
        base.OnModelCreating(modelBuilder);
    }
}