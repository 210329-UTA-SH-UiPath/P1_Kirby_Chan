using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    /// <summary>
    /// Topping Model
    /// </summary>
    public class Topping
    {
        public Topping()
        {
            PresetPizzas = new List<PresetPizza>();
            Pizzas = new List<Pizza>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual List<PresetPizza> PresetPizzas { get; set; }
        public virtual List<Pizza> Pizzas { get; set; }
    }
}