using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieProjectGr13BDataLayer;
using MovieProjectGr13B.Models.Database;

namespace MovieProjectGr13B.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff

        MovieProjectContext db = new MovieProjectContext();
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }
        public ActionResult AddMovie()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddMovie(Movie m1)
        {
            if (!ModelState.IsValid) {return View(m1); }
            db.Movies.Add(m1);
            db.SaveChanges();
            return View();
        }

        public ActionResult ListCustOrders()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ListCustOrders(int id)
        {
            var filteredResult = db.Orders.Where(m => m.CustomerId == id).ToList();

            return View(filteredResult);
        }
    }
}