using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;

namespace IA.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public float price { get; set; }
        public string Image { get; set; }
        public string description { get; set; }
        [ForeignKey("category")]
        public int category_id { get; set; }

        public virtual Category category { get; set; }
    }
}