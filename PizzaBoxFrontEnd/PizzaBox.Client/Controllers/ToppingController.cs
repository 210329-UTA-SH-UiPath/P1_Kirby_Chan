using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Client.Controllers
{
    public class ToppingController : Controller
    {
        Client client = new Client();
        public IActionResult Index()
        {
            var toppings = client.GetAllToppings();

            return View(toppings);
        }
    }
}
