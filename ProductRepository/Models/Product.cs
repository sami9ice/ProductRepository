﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductRepository.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description  { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public virtual Cartegory Cartegory { get; set; } 

    }
}