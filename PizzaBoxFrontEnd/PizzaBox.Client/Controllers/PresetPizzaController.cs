using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Client.Controllers
{
    public class PresetPizzaController : Controller
    {
        MenuClient client = new MenuClient();
        public IActionResult Index()
        {
            var presetPizzas = client.GetAllPresetPizzas();

            return View(presetPizzas);
        }
    }
}
