using PokemonWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokemonWebApp.Controllers
{
    public class HomeController : Controller
    {
        internal PokemonService _pokeService;

        /// <summary>
        /// Initializes a PokemonService upon initialization
        /// </summary>
        public HomeController() {
            _pokeService = new PokemonService();
        }

        /// <summary>
        /// Accessing the Home controller will send the user to 
        /// a default list of all stored Pokemon in the Pokedex
        /// </summary>
        /// <returns>Index view listing all stored Pokemon</returns>
        public ActionResult Index() {
            return View(_pokeService.GetPokedex());
        }

    }
}