using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Client.Controllers
{
    public class ToppingController : Controller
    {
        MenuClient client = new MenuClient();
        public IActionResult Index()
        {
            var toppings = client.GetAllToppings();

            return View(toppings);
        }
    }
}
