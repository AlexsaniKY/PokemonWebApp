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
    /// <summary>
    /// Pokemon controller for all operations involving Pokemon objects
    /// </summary>
    public class PokemonController : Controller
    {
        internal PokemonService _pokeService;

        /// <summary>
        /// Creates a PokemonService upon initialization
        /// </summary>
        public PokemonController() {
            _pokeService = new PokemonService();
        }

        /// <summary>
        /// Accesses a Pokemon Object through the PokemonService
        /// </summary>
        /// <param name="id">an Id matching a stored Pokemon</param>
        /// <returns>Details view with matching Pokemon information or HttpNotFoundResult if Pokemon is not found</returns>
        public ActionResult Get(int id) {
            PokemonViewModel foundpoke = _pokeService.GetPokemonViewModel(id);
            if (foundpoke == null)
                return new HttpNotFoundResult();
            else return View(foundpoke);
        }

        /// <summary>
        /// Opens dialog for removing a stored Pokemon Object accessed through a PokemonService
        /// </summary>
        /// <param name="id">an Id matching a stored Pokemon</param>
        /// <returns>Details view for confirmation of Pokemon deletion or HttpNotFoundResult if Pokemon is not found</returns>
        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (_pokeService.HasPokemon(id))
                return View(_pokeService.GetPokemonViewModel(id));
            else return new HttpNotFoundResult();
        }

        /// <summary>
        /// Removes Pokemon Object if found
        /// </summary>
        /// <param name="id">an Id matching a stored Pokemon</param>
        /// <returns>Index of all remaining Pokemon if successful, or HttpNotFoundResult if Pokemon is not found</returns>
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id) {
            if (_pokeService.DeletePokemon(id))
                return View("~/Views/Home/Index.cshtml", _pokeService.GetPokedex());
            else return new HttpNotFoundResult();
            
        }

        /// <summary>
        /// Access a Pokemon creation form
        /// </summary>
        /// <returns>View with Pokemon creation form</returns>
        [HttpGet]
        public ActionResult AddPokemon() {
            return View(new PokemonViewModel());
        }

        /// <summary>
        /// Stores a new Pokemon Object
        /// </summary>
        /// <param name="newPokemon">the Pokemon intending to be stored</param>
        /// <returns>Index view showing all stored Pokemon or a HttpStatusCode indicating conflict with existing Pokemon resource </returns>
        [HttpPost]
        public ActionResult AddPokemon(PokemonViewModel newPokemon) {
            if (_pokeService.AddPokemon(newPokemon))
                return View("~/Views/Home/Index.cshtml", _pokeService.GetPokedex());
            else return new HttpStatusCodeResult(HttpStatusCode.Conflict);
        }

        /// <summary>
        /// Opens Edit page for an existing Pokemon Object
        /// </summary>
        /// <param name="id">Id of Pokemon Object to be editted</param>
        /// <returns>Edit View containing Pokemon to be altered or HttpNotFoundResult if no Pokemon is found with given Id</returns>
        public ActionResult Edit(int id) {
            PokemonViewModel foundpoke = _pokeService.GetPokemonViewModel(id);
            if (foundpoke == null)
                return new HttpNotFoundResult();
            return View(foundpoke);
        }

        /// <summary>
        /// Alters existing record of a Pokemon Object
        /// </summary>
        /// <param name="alteredPokemon">Pokemon with altered details to be stored</param>
        /// <returns>Index view containing all stored Pokemon or a HttpNotFoundResult if Pokemon is not already stored</returns>
        [HttpPost]
        public ActionResult Edit(PokemonViewModel alteredPokemon) {
            if (_pokeService.UpdatePokemon(alteredPokemon))
                return View("~/Views/Home/Index.cshtml", _pokeService.GetPokedex());
            else return new HttpNotFoundResult();
        }
    }
}