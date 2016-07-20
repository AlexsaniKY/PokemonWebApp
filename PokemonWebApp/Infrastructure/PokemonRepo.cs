using PokemonWebApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonWebApp.Infrastructure
{
    public static class PokemonRepo
    {
        internal static Pokedex _pokedex { get; set; }

        static PokemonRepo()
        {
            _pokedex = new Pokedex
            {
                { 1, new Pokemon(1, "Bulbasaur", Domain.Type.Types.grass, 1) },
                { 2, new Pokemon(2, "Ivysaur", Domain.Type.Types.grass, 5) },
                { 3, new Pokemon(1, "Venusaur", Domain.Type.Types.grass, 10) }

            };
        }

        public static void AddPokemon(Pokemon newPokemon) {
            _pokedex.Add(newPokemon.Id, newPokemon);
        }

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