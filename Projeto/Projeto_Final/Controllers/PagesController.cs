using Microsoft.AspNetCore.Mvc;

namespace Projeto_Final.Controllers {
    public class PagesController : Controller {

        [HttpGet]

        public IActionResult Index () {

            return View ();
        }

        [HttpGet]

        public IActionResult Sobre () {

            return View ();
        }

        [HttpGet]

        public IActionResult Perguntas () {

            return View ();
        }

        [HttpGet]

        public IActionResult Contatos () {

            return View ();

        }

        [HttpGet]
        public IActionResult Depoimentos(){

            return View();
        }

    }
}