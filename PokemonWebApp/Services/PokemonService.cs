using PokemonWebApp.Domain;
using PokemonWebApp.Infrastructure;
using PokemonWebApp.Services.ViewModels;
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

        public void AddPokemon(PokemonViewModel newPokemon) {
            _repo.AddPokemon(new Pokemon(newPokemon));
        }

        public Pokedex GetPokedex() {
            return _repo.GetPokedex();
        }
    }
}