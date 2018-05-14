using ProductRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductRepository.RepoPattern
{
    public interface IProdRepository 
    {
        IEnumerable<Product> GetAll();
        
    }
  
}