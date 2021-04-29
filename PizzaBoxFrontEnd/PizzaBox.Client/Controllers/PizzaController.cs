using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
    public class PizzaController : Controller
    {
        MenuClient client = new MenuClient();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetPresetPizza()
        {
            var presetPizzas = client.GetAllPresetPizzas();

            ViewBag.PresetPizzas = new SelectList(presetPizzas, "ID", "Name");
            return View();
        }
        
        [HttpPost]
        public IActionResult PresetPizzaSelected(PresetPizza presetPizza)
        {
            var pizzaType = client.GetAllPresetPizzas().FirstOrDefault(s => s.ID == presetPizza.ID);
            var sessionOrder = Utils.GetCurrentOrder(HttpContext.Session);
            
            sessionOrder.Pizzas.Add(new Pizza());
            var currentPizza = sessionOrder.Pizzas.Last();

            currentPizza.PresetPizza = pizzaType;
            currentPizza.Toppings = pizzaType.Toppings;

            Utils.SaveOrder(HttpContext.Session, sessionOrder);


            return RedirectToAction("GetSize");
        }
        [HttpGet]
        public IActionResult GetSize()
        {
            var sizes = client.GetAllSizes();

            ViewBag.Sizes = new SelectList(sizes, "ID", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult SizeSelected(Size size)
        {
            var pizzaSize = client.GetAllSizes().FirstOrDefault(s => s.ID == size.ID);
            var sessionOrder = Utils.GetCurrentOrder(HttpContext.Session);

            var currentPizza = sessionOrder.Pizzas.Last();

            currentPizza.Size = new Size();
            currentPizza.Size.ID = pizzaSize.ID;
            currentPizza.Size.Name = pizzaSize.Name;
            currentPizza.Size.Price = pizzaSize.Price;

            Utils.SaveOrder(HttpContext.Session, sessionOrder);


            return RedirectToAction("GetCrust");
        }
        [HttpGet]
        public IActionResult GetCrust()
        {
            var crusts = client.GetAllCrusts();

            ViewBag.Crusts = new SelectList(crusts, "ID", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult CrustSelected(Crust crust)
        {
            var pizzaCrust = client.GetAllCrusts().FirstOrDefault(s => s.ID == crust.ID);
            var sessionOrder = Utils.GetCurrentOrder(HttpContext.Session);

            var currentPizza = sessionOrder.Pizzas.Last();

            currentPizza.Crust = new Crust();
            currentPizza.Crust.ID = pizzaCrust.ID;
            currentPizza.Crust.Name = pizzaCrust.Name;
            currentPizza.Crust.Price = pizzaCrust.Price;

            Utils.SaveOrder(HttpContext.Session, sessionOrder);


            return View("Index", currentPizza);
        }

        [HttpGet]
        public IActionResult GetTopping()
        {
            var toppings = client.GetAllToppings();

            ViewBag.Toppings = new SelectList(toppings, "ID", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult ToppingSelected(Topping topping)
        {
            var pizzaTopping = client.GetAllToppings().FirstOrDefault(s => s.ID == topping.ID);
            var sessionOrder = Utils.GetCurrentOrder(HttpContext.Session);

            var currentPizza = sessionOrder.Pizzas.Last();

            currentPizza.Toppings.Add(pizzaTopping);

            Utils.SaveOrder(HttpContext.Session, sessionOrder);

            return View("Index", currentPizza);
        }
    }
}
