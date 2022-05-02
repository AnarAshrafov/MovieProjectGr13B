using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieProjectGr13BDataLayer;
using MovieProjectGr13B.Models.Database;

namespace MovieProjectGr13B.Controllers
{
    public class ShopController : Controller
    {
        // GET: Movie
        MovieProjectContext db = new MovieProjectContext();
        public ActionResult Index()
        {

            return View();
        }
    }
}