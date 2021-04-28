using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Client.Controllers
{
    public class SizeController : Controller
    {
        Client client = new Client();
        public IActionResult Index()
        {
            var sizes = client.GetAllSizes();

            return View(sizes);
        }
    }
}
