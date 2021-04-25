using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class PresetPizza
    {
        public PresetPizza()
        {
            Toppings = new List<Topping>();
        }
        public int ID { get; set; }

        public string Name { get; set; }
        public virtual ICollection<Topping> Toppings { get; set; }
    }
}
