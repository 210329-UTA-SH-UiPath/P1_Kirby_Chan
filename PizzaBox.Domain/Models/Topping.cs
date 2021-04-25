using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    /// <summary>
    /// Topping Model
    /// </summary>
    public class Topping
    {
        private ICollection<PresetPizza> presetPizzas;

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<PresetPizza> PresetPizzas { get => presetPizzas; set => presetPizzas = value; }
        public virtual ICollection<Pizza> Pizzas { get; set; }
    }
}