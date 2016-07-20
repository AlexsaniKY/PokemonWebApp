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

        public HomeController() {
            _pokeService = new PokemonService();
        }

        public ActionResult Index() {
            return View(_pokeService.GetPokedex());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}