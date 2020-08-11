using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;
using PizzaBox.Storing;
using PizzaBox.Domain.Models;
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
        public IActionResult PlaceOrder(PizzaViewModel pvm)
        {
            CrustModel c = new CrustModel(){Name = pvm.crust};
            SizeModel s = new SizeModel(){Name = pvm.size};
            List<ToppingsBase> t = new List<ToppingsBase>();
            int toppingCounter = 0;
            int refToppingCounter = 0;
            foreach (var toppingStr in pvm.SelectedToppings)
            {
                refToppingCounter=0;
                foreach (var referenceTopping in pvm.ToppingsBase)
                {
                    System.Console.WriteLine("Yeet");
                    System.Console.WriteLine(pvm.ToppingsBase.ElementAt(0));
                    if(referenceTopping.Name.Equals(toppingStr))
                    {
                        t.Add(pvm.ToppingsBase.ElementAt(refToppingCounter));
                    }
                    refToppingCounter++;
                }
                toppingCounter++;
            }
            
            PizzaModel p = new PizzaModel(){Crust = c, Size = s, Toppings = t};
            OrderModel o = new OrderModel(){Pizzas = new List<PizzaModel>(){p}};
            _db.Orders.Add(o);
            return View("displayOrders", o);
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
