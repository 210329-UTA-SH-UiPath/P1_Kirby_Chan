using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    /// <summary>
    /// Pizza Model
    /// </summary>
    public class Pizza
    {
        public Pizza()
        {
            Toppings = new List<Topping>();
        }

        public int ID { get; set; }
        public PresetPizza PresetPizza { get; set; }
        public Order Order { get; set; }
        public Crust Crust { get; set; }
        public Size Size { get; set; }
        public List<Topping> Toppings { get; set; }
        public decimal Price { get; set; }
    }
}