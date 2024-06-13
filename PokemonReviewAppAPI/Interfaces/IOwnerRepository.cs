using PokemonReviewAppAPI.Models;

namespace PokemonReviewAppAPI.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwnerById(int ownerId);
        ICollection<Owner> GetOwnersByPokemon(int pokemonId);
        ICollection<Pokemon> GetPokemonsOfAOwner(int ownerId);
        bool OwnerExists(int ownerId);
    }
}
