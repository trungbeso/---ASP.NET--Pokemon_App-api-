using AutoMapper;
using PokemonReviewApp.Api.Dtos;
using PokemonReviewApp.Api.Entities;

namespace PokemonReviewApp.Api.Util;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Pokemon, PokemonDto>();
    }
}