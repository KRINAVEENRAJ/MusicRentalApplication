using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Music.Models;
using Music.ViewModel;

namespace Music.Controllers
{
    public class MusicController : Controller
    {
        
        public ActionResult RamdomView()
        {
            var randomViewModel = new RandomViewModel();
            randomViewModel.Movie = new Movies() { Name = "Sherk!", MovieId = Guid.NewGuid() };
            randomViewModel.Customer = new List<Customer>()
            {
                new Customer(){CustomerId = Guid.NewGuid()},
                new Customer(){CustomerId = Guid.NewGuid()},
                new Customer(){CustomerId = Guid.NewGuid()}

            };
            return View(randomViewModel);
        }

        public ActionResult MusicViewPoint()
        {
            var randomViewModel = new RandomViewModel();
            randomViewModel.Movie = new Movies() { Name = "Sherk!", MovieId = Guid.NewGuid() };

            return View(randomViewModel);

        }


        public ActionResult Redirecting()
        {
            return RedirectToAction("RadomContent","Music");

        }
        public ContentResult RadomContent(string number)
        {
            return Content("<h1 style=\"font-family:Helvetica;\">Naveenraj</h1>" );
        }
        public HttpNotFoundResult HttpNotFoundResult()
        {
            return new HttpNotFoundResult();
        }
        public EmptyResult EmptyResult1()
        {
            return  new EmptyResult();
        }
	}
}