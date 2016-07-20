using PokemonWebApp.Services;
using PokemonWebApp.Services.ViewModels;
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

        public ActionResult Get(int id) {
            return View(_pokeService.GetPokemon(id));
        }

        [HttpGet]
        public ActionResult AddPokemon() {
            return View(new PokemonViewModel());
        }

        [HttpPost]
        public ActionResult AddPokemon(PokemonViewModel newPokemon) {
            _pokeService.AddPokemon(newPokemon);

            return RedirectToAction("Index", "Home", "Home");
        }
    }
}