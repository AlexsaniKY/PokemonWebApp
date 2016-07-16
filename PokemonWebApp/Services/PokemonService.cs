using PokemonWebApp.Domain;
using PokemonWebApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonWebApp.Services
{
    public class PokemonService
    {
        internal PokemonRepo _repo;

        public PokemonService() {
            _repo = new PokemonRepo();
        }

        public Pokemon GetPokemon(int id) {
            return _repo.GetPokemon(id);
        }
    }
}