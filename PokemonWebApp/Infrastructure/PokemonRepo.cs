using PokemonWebApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonWebApp.Infrastructure
{
    /// <summary>
    /// Pokemon Repository for storing any valid Pokemon Objects in a Pokedex
    /// </summary>
    public static class PokemonRepo
    {
        /// <summary>
        /// internal Pokedex for storing Pokemon Objects
        /// </summary>
        internal static Pokedex _pokedex { get; set; }

        /// <summary>
        /// Default initialization primes repository with the first 3 Pokemon
        /// </summary>
        static PokemonRepo()
        {
            _pokedex = new Pokedex();
            AddPokemon(new Pokemon(1, "Bulbasaur", Domain.Type.Types.grass, 1));
            AddPokemon(new Pokemon(2, "Ivysaur", Domain.Type.Types.grass, 5));
            AddPokemon(new Pokemon(3, "Venusaur", Domain.Type.Types.grass, 10));
        }

        /// <summary>
        /// Checks if Pokemon exists in Pokedex
        /// </summary>
        /// <param name="id">Index of stored pokemon</param>
        /// <returns>bool of whether a Pokemon exists with given Key</returns>
        public static bool HasPokemon(int id) {
            return _pokedex.ContainsKey(id);
        }

        /// <summary>
        /// Adds a Pokemon to the Pokedex
        /// </summary>
        /// <param name="newPokemon">Pokemon Object to be added</param>
        /// <returns>bool of whether Pokemon Object could be added (false if already exists, does not overwrite)</returns>
        public static bool AddPokemon(Pokemon newPokemon) {
            try
            {
                _pokedex.Add(newPokemon.Id, newPokemon);
                return true;
            }
            catch (Exception d){
                return false;
            }
        }

        /// <summary>
        /// Updates existing Pokemon Object record in Pokedex
        /// </summary>
        /// <param name="alteredPokemon">exisitng Pokemon record to be modified</param>
        /// <returns>bool of whether the record exists and has been updated</returns>
        public static bool UpdatePokemon(Pokemon alteredPokemon) {
            if (_pokedex.ContainsKey(alteredPokemon.Id))
            {
                _pokedex[alteredPokemon.Id] = alteredPokemon;
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Deletes existing Pokemon record from Pokedex
        /// </summary>
        /// <param name="id">Id of Pokemon to remove</param>
        /// <returns>bool of whether Pokemon record existed to be deleted</returns>
        public static bool DeletePokemon(int id)
        {
            if (_pokedex.ContainsKey(id)) {
                _pokedex.Remove(id);
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Returns Pokemon record
        /// </summary>
        /// <param name="id">Id of Pokemon to find</param>
        /// <returns>Pokemon Object reflecting what was stored in Pokedex or null if not found</returns>
        public static Pokemon GetPokemon(int id)
        {
            return (from p in _pokedex.AsEnumerable()
                    where p.Key == id
                    select p.Value).FirstOrDefault();
        }

        public static Pokedex GetPokedex() {
            return _pokedex;
        }
    }
}