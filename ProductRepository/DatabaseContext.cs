using ProductRepository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductRepository
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext():base($"name={nameof(Database)}")
        {

        }
        public DbSet<Product> Product { get; set; }
    }
}