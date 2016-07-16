using PokemonWebApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonWebApp.Infrastructure
{
    public class PokemonRepo
    {
        internal static Dictionary<int, Pokemon> _pokedex { get; set; }

        public PokemonRepo()
        {
            _pokedex = new Dictionary<int, Pokemon>
            {
                { 1, new Pokemon(1, "Bulbasaur", Domain.Type.Types.grass, 1) },
                { 2, new Pokemon(2, "Ivysaur", Domain.Type.Types.grass, 5) },
                { 3, new Pokemon(1, "Venusaur", Domain.Type.Types.grass, 10) }

            };
        }

        public Pokemon GetPokemon(int id)
        {
            return (from p in _pokedex.AsEnumerable()
                    where p.Key == id
                    select p.Value).FirstOrDefault();
        }

    }
}