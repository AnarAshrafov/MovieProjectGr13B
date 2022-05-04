using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieProjectGr13BDataLayer;
using MovieProjectGr13B.Models.Database;

namespace MovieProjectGr13B.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        MovieProjectContext db = new MovieProjectContext();
        public ActionResult Index(int? id)
        {
            List<Order> orderList = new List<Order>();

            if (id == null || id == 0)
            {
                orderList = db.Orders.ToList();
            }
            else
            {
                orderList = db.Orders.Where(o => o.CustomerId == id).ToList();
            }

            return View(orderList);
        }
    }
}