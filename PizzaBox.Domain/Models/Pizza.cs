using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public PresetPizza PresetPizza { get; set; }
        [Required]
        public Order Order { get; set; }
        [Required]
        public Crust Crust { get; set; }
        [Required]
        public Size Size { get; set; }
        [Required]
        public List<Topping> Toppings { get; set; }
        public decimal Price { get; set; }
    }
}