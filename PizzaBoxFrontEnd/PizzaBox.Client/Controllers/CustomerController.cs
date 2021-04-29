using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
    public class CustomerController : Controller
    {
        OrderClient client = new OrderClient();
        //  
        [HttpGet]
        public ViewResult GetCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetCustomer( string name )
        {
            if (name != null)
            {
                Customer customer = client.GetCustomerByName(name);

                var sessionOrder = Utils.GetCurrentOrder(HttpContext.Session);
                sessionOrder.Customer = new Customer();
                sessionOrder.Customer.ID = customer.ID;
                sessionOrder.Customer.Name = customer.Name;
                Utils.SaveOrder(HttpContext.Session, sessionOrder);

                return RedirectToAction("GetStore", "Store");
            }
            else
            {
                return View();
            }
        }
    }
}
