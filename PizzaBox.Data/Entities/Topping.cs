using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Data.Entities
{
    public class Topping
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<PresetPizza> PresetPizzas { get; set; }
        public virtual ICollection<Pizza> Pizzas { get; set; }
    }
}
