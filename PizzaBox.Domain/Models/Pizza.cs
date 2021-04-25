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
        public virtual PresetPizza PresetPizza { get; set; }
        public virtual Order Order { get; set; }
        public virtual Crust Crust { get; set; }
        public virtual Size Size { get; set; }
        public virtual ICollection<Topping> Toppings { get; set; }
        public decimal Price { get; set; }
    }
}