using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
    public class StoreController : Controller
    {
        MenuClient client = new MenuClient();
        public IActionResult Index()
        {
            var stores = client.GetAllStores();

            return View(stores);
        }

        [HttpGet]
        public IActionResult GetStore()
        {
            var stores = client.GetAllStores();

            ViewBag.Stores = new SelectList( stores, "ID", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult StoreSelected(Store store)
        {
            var orderStore = client.GetAllStores().FirstOrDefault(s => s.ID == store.ID);
            var sessionOrder = Utils.GetCurrentOrder(HttpContext.Session);
            sessionOrder.Store = new Store();
            sessionOrder.Store.ID = orderStore.ID;
            sessionOrder.Store.Name = orderStore.Name;
            Utils.SaveOrder(HttpContext.Session, sessionOrder);


            return View("../Order/Index", sessionOrder);
        }
    }
}
