using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Client.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult CustomerOrders(int id)
        {
            return View();
        }

        public IActionResult StoreOrders(int id)
        {
            return View();
        }
        public IActionResult ViewOrder()
        {
            return View();
        }
        public IActionResult SaveOrder()
        {
            return View();
        }
    }
}
