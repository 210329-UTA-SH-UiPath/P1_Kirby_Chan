using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    /// <summary>
    /// Topping Model
    /// </summary>
    public class Topping
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}