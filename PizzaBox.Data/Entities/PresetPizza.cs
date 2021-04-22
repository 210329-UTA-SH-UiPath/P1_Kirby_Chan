using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Data.Entities
{
    class PresetPizza
    {
        public PresetPizza()
        {
            Toppings = new List<Topping>();
        }
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        public virtual ICollection<Topping> Toppings { get; set; }

    }
}
