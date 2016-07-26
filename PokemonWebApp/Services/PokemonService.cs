using PokemonWebApp.Domain;
using PokemonWebApp.Infrastructure;
using PokemonWebApp.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonWebApp.Services
{
    /// <summary>
    /// Pokemon Services class for all Pokemon Object interactions to Pokemon Repository
    /// </summary>
    public class PokemonService
    {
        /// <summary>
        /// Attempts to return a stored Pokemon record
        /// </summary>
        /// <param name="id">Id of desired Pokemon</param>
        /// <returns>found Pokemon Object or null</returns>
        public Pokemon GetPokemon(int id) {
            return PokemonRepo.GetPokemon(id);
        }

        /// <summary>
        /// Attempts to return a stored Pokemon record as a PokemonViewModel
        /// </summary>
        /// <param name="id">Id of desired Pokemon</param>
        /// <returns>found Pokemon Object as PokemonViewModel or null</returns>
        public PokemonViewModel GetPokemonViewModel(int id) {
            Pokemon returnval = PokemonRepo.GetPokemon(id);
            if (returnval == null)
                return null;
            else return new PokemonViewModel(returnval);
        }

        /// <summary>
        /// Attempts to add a new Pokemon Record
        /// </summary>
        /// <param name="newPokemon">PokemonViewModel to store</param>
        /// <returns>bool of whether addition was successful.  False if record already exists</returns>
        public bool AddPokemon( PokemonViewModel newPokemon) {
            return PokemonRepo.AddPokemon(new Pokemon(newPokemon));
        }

        /// <summary>
        /// Attempts to delete existing Pokemon Record
        /// </summary>
        /// <param name="removeId">Id of Pokemon record to remove</param>
        /// <returns>bool of whether deletion was successful.  False if record did not exist</returns>
        public bool DeletePokemon(int removeId){
            return PokemonRepo.DeletePokemon(removeId);
        }

        /// <summary>
        /// Checks if Pokemon Record exists
        /// </summary>
        /// <param name="id">Id of Pokemon to search for</param>
        /// <returns>bool of whether record exists</returns>
        public bool HasPokemon(int id) {
            return PokemonRepo.HasPokemon(id);
        }

        /// <summary>
        /// returns full Pokedex of stored Pokemon
        /// </summary>
        /// <returns>Pokedex snapshot</returns>
        public Pokedex GetPokedex() {
            return PokemonRepo.GetPokedex();
        }

        /// <summary>
        /// Attempts to update record of existing Pokemon
        /// </summary>
        /// <param name="alteredPokemon">PokemonViewModel representing an existing record to be modified</param>
        /// <returns>bool of whether successful.  False if record does not exist</returns>
        public bool UpdatePokemon(PokemonViewModel alteredPokemon) {
            return PokemonRepo.UpdatePokemon(new Pokemon(alteredPokemon));
        }
    }
}