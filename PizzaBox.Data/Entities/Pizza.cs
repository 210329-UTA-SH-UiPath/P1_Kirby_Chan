using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PizzaBox.Data.Entities
{
    class Pizza
    {
        public Pizza()
        {
            Toppings = new List<Topping>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        public virtual PresetPizza PresetPizza { get; set; }
        [Required]
        public virtual Order Order { get; set; }
        [Required]
        public virtual Crust Crust { get; set; }
        [Required]
        public virtual Size Size { get; set; }
        [Required]
        public virtual ICollection<Topping> Toppings { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
