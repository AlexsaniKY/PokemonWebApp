﻿using PokemonWebApp.Domain;
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

        public void AddPokemon(PokemonViewModel newPokemon) {
            PokemonRepo.AddPokemon(new Pokemon(newPokemon));
        }

        public Pokedex GetPokedex() {
            return PokemonRepo.GetPokedex();
        }
    }
}