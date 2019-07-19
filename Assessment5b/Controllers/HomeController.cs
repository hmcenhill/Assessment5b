using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assessment5b.Models;
using Microsoft.AspNetCore.Http;

namespace Assessment5b.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ISession _session;

        //public HomeController(IHttpContextAccessor httpContextAccessor)
        //{
        //    _session = httpContextAccessor.HttpContext.Session;
        //}



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Item()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Item(int id)
        {
            // if (id == 1) _cart.Item1++;
            return View();
        }

        public IActionResult Checkout(Cart _cart)
        {
            if (_cart == null) _cart = new Cart();

            if (_cart.Item1 < 0) _cart.Item1 = 0;
            if (_cart.Item2 < 0) _cart.Item2 = 0;
            if (_cart.Item3 < 0) _cart.Item3 = 0;

            return View(_cart);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
