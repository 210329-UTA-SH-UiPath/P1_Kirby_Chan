using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Data.Entities
{
    public class Crust
    {
        public Crust()
        {
        }

        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
