using AutoMapper;
using PokemonReviewAppAPI.Dto;
using PokemonReviewAppAPI.Models;

namespace PokemonReviewAppAPI.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Country, CountryDto>();
        }
    }
}
