using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Client.Controllers
{
    public class OrderController : Controller
    {
        OrderClient client = new OrderClient();
        public IActionResult CustomerOrders(int id)
        {
            var orders = client.GetOrdersByCustomerId(id);
            return View("CustomerOrders", orders);
        }

        public IActionResult Index()
        {
            var sessionOrder = Utils.GetCurrentOrder(HttpContext.Session);
            return View("Index", sessionOrder);
        }

        public IActionResult StoreOrders(int id)
        {
            return View();
        }
        public IActionResult ViewOrder()
        {
            var sessionOrder = Utils.GetCurrentOrder(HttpContext.Session);
            return View(sessionOrder);
        }
        public IActionResult SaveOrder()
        {
            var sessionOrder = Utils.GetCurrentOrder(HttpContext.Session);
            client.AddOrder(sessionOrder);

            return View();
        }
    }
}
