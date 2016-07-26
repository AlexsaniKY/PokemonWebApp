using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonWebApp.Domain
{
    /// <summary>
    /// Type is intended to hold all interactions between pokemon types.  It contains a
    /// public enum Types for access to built in types and holds 
    /// </summary>
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

        /// <summary>
        /// publicly settable enum to hold a pokemon's type
        /// </summary>
        public Types MyType { get; set; }
        
        /// <summary>
        /// Type class must be initialized with a default Type.Types value
        /// </summary>
        /// <param name="type">a Type.Types enum representing this Type's stored value</param>
        public Type(Type.Types type)
        {
            MyType = type;
        }
    }
}