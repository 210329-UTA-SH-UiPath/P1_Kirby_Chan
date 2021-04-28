using System.Collections.Generic;

namespace PizzaBox.Client.Models
{
    public class PresetPizza
    {
        public PresetPizza()
        {
            Toppings = new List<Topping>();
        }
        public int ID { get; set; }

        public string Name { get; set; }
        public List<Topping> Toppings { get; set; }
    }
}
