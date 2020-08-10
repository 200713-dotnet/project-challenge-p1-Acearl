using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
    public class OrderController : Controller
    {
        private PizzaBoxDbContext _db;
        private readonly ILogger<HomeController> _logger;

        public OrderController(ILogger<HomeController> logger, PizzaBoxDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Order()
        {
            return View(new PizzaViewModel(_db));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
