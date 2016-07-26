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

        public Pokemon GetPokemon(int id) {
            return PokemonRepo.GetPokemon(id);
        }

        public PokemonViewModel GetPokemonViewModel(int id) {
            Pokemon returnval = PokemonRepo.GetPokemon(id);
            if (returnval == null)
                return null;
            else return new PokemonViewModel(returnval);
        }

        public bool AddPokemon( PokemonViewModel newPokemon) {
            return PokemonRepo.AddPokemon(new Pokemon(newPokemon));
        }

        public bool DeletePokemon(int removeId){
            return PokemonRepo.DeletePokemon(removeId);
        }

        public bool HasPokemon(int id) {
            return PokemonRepo.HasPokemon(id);
        }

        public Pokedex GetPokedex() {
            return PokemonRepo.GetPokedex();
        }

        public bool UpdatePokemon(PokemonViewModel alteredPokemon) {
            return PokemonRepo.UpdatePokemon(new Pokemon(alteredPokemon));
        }
    }
}