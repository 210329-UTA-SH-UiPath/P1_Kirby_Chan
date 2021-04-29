using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Client.Controllers
{
    public class CrustController : Controller
    {
        MenuClient client = new MenuClient();
        public IActionResult Index()
        {
            var crusts = client.GetAllCrusts();

            return View(crusts);
        }
    }
}