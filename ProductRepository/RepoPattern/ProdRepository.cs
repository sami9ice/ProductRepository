using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductRepository.Models;

namespace ProductRepository.RepoPattern
{
    public class ProdRepository : IProdRepository
    {
        DatabaseContext db = new DatabaseContext();
        public IEnumerable<Product> GetAll()
        {
            return db.Set<Product>().ToList();
        }
    }
}