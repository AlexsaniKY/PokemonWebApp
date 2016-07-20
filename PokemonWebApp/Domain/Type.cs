using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonWebApp.Domain
{
    public class Type
    {
        public enum Types {
            fire,
            water,
            grass,
            normal,
            ghost,
            electric
        }

        public Types MyType { get; set; }
        
        public Type(Type.Types type)
        {
            MyType = type;
        }
    }
}