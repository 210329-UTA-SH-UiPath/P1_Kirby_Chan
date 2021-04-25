using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    /// <summary>
    /// Order Model
    /// </summary>
    public class Order
    {
        public Order()
        {
            Pizzas = new List<Pizza>();
        }

        public int ID { get; set; }
        public  Store Store { get; set; }
        public  Customer Customer { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime TimePlaced { get; set; }
    }
}