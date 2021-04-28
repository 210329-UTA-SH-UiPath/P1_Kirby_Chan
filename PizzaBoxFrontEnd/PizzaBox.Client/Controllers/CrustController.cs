using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Client.Controllers
{
    public class CrustController : Controller
    {
        Client client = new Client();
        public IActionResult Index()
        {
            var crusts = client.GetAllCrusts();

            return View(crusts);
        }
    }
}