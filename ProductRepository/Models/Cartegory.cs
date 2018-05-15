using System;
using System.ComponentModel.DataAnnotations;

namespace ProductRepository.Models
{
    public class Cartegory
    {
        [Required]
        public int Id { get; set; }
        public string CartegoryName  { get; set; }

        
    }
}