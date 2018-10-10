using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Music.Models;
using Music.ViewModel;

namespace Music.Controllers
{
    public class MoviesController : Controller
    {
        //
        // GET: /Movies/
        [Route("movies/releasedby")]
        public ActionResult Rndex()
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
        
        //[Route("movies/releasedby/{year/{month:range(0,12)}")]
        //public ContentResult Released(int year,int month)
        //{
        //    return Content("Released By Year:"+year+"Month:"+month);
        //}

       

	}
}