using PokemonWebApp.Services;
using PokemonWebApp.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace PokemonWebApp.Controllers
{
    public class PokemonController : Controller
    {
        internal PokemonService _pokeService;

        public PokemonController() {
            _pokeService = new PokemonService();
        }

        public ActionResult Get(int id) {
            PokemonViewModel foundpoke = _pokeService.GetPokemonViewModel(id);
            if (foundpoke == null)
                return new HttpNotFoundResult();
            else return View(foundpoke);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (_pokeService.HasPokemon(id))
                return View(_pokeService.GetPokemonViewModel(id));
            else return new HttpNotFoundResult();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id) {
            if (_pokeService.DeletePokemon(id))
                return View("~/Views/Home/Index.cshtml", _pokeService.GetPokedex());
            else return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            
        }

        [HttpGet]
        public ActionResult AddPokemon() {
            return View(new PokemonViewModel());
        }

        [HttpPost]
        public ActionResult AddPokemon(PokemonViewModel newPokemon) {
            if (_pokeService.AddPokemon(newPokemon))
                return View("~/Views/Home/Index.cshtml", _pokeService.GetPokedex());
            else return new HttpStatusCodeResult(HttpStatusCode.Conflict);
        }

        public ActionResult Edit(int id) {
            PokemonViewModel foundpoke = _pokeService.GetPokemonViewModel(id);
            if (foundpoke == null)
                return new HttpNotFoundResult();
            return View(foundpoke);
        }

        [HttpPost]
        public ActionResult Edit(PokemonViewModel alteredPokemon) {
            if (_pokeService.UpdatePokemon(alteredPokemon))
                return View("~/Views/Home/Index.cshtml", _pokeService.GetPokedex());
            else return new HttpNotFoundResult();
        }
    }
}