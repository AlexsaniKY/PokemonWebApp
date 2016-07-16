using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonWebApp.Domain
{
    public class Pokemon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Type Type { get; set; }

        public int Level { get; set; }

        public Pokemon(int id, string name, Type.Types type, int level)
        {
            Id = id;
            Name = name;
            Type = new Type(type);
            Level = level;
        }
    }
}