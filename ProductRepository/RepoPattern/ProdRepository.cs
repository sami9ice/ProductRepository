using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductRepository.Models;

namespace ProductRepository.RepoPattern
{
    public class ProdRepository : IProdRepository
    {
        private DatabaseContext GetProductContext;
        public ProdRepository()
        {
            GetProductContext = new DatabaseContext();
        }
        DatabaseContext db = new DatabaseContext();
        public IEnumerable<Product> GetAll()
        {
            //return GetProductContext.Set<Product>().ToList();
            return db.Set<Product>().ToList();
        }
    }
}