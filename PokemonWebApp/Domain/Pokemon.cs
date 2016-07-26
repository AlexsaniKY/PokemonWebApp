using PokemonWebApp.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonWebApp.Domain
{
    /// <summary>
    /// Pokemon Object for storing all necessary properties of a Pokemon
    /// </summary>
    public class Pokemon
    {

        /// <summary>
        /// Id of Pokemon, intended as an indice for which "number" the Pokemon exists at
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of Pokemon
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of Pokemon
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// First level the Pokemon may appear at
        /// </summary>
        public int Level { get; set; }



        public Pokemon() { }

        public Pokemon(int id, string name, Type.Types type, int level)
        {
            Id = id;
            Name = name;
            Type = new Type(type);
            Level = level;
        }

        public Pokemon(PokemonViewModel pokeVM) {
            Id = pokeVM.Id;
            Name = pokeVM.Name;
            //found the parsing solution here http://stackoverflow.com/questions/13970257/casting-string-to-enum
            Type = new Type((Type.Types)Enum.Parse(typeof(Type.Types), pokeVM.Type.ToLower()));
            Level = pokeVM.Level;
        }
    }
}