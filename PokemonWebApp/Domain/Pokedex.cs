using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonWebApp.Domain {
    /// <summary>
    /// Pokedex is a Dictionary of int, Pokemon pairs
    /// </summary>
    public class Pokedex : Dictionary<int, Pokemon> { }
}