using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Client.Controllers
{
    public class PresetPizzaController : Controller
    {
        Client client = new Client();
        public IActionResult Index()
        {
            var presetPizzas = client.GetAllPresetPizzas();

            return View(presetPizzas);
        }
    }
}
