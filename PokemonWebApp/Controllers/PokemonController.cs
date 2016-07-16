using PokemonWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokemonWebApp.Controllers
{
    public class PokemonController : Controller
    {
        internal PokemonService _pokeService;

        public PokemonController() {
            _pokeService = new PokemonService();
        }

        // GET: Pokemon
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Get(int id) {
            return View(_pokeService.GetPokemon(id));
        }

    }
}