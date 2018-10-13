using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Customer List shouls be displayed here";
            List<Customer> customerList = new List<Customer>
            {
                new Customer(){Name= "Geetesh",Id=1},
                new Customer(){Name= "Vishva",Id=2},
                new Customer(){Name= "Bhaskar",Id=3}
            };
            return View(customerList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}