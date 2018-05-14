using ProductRepository;
using ProductRepository.Models;
using ProductRepository.RepoPattern;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Mvc;

namespace ProductsApp.Controllers
{
    public class ProductsController : Controller
    {
        private DatabaseContext db = new DatabaseContext();
        //private ProdRepository database = new ProdRepository();
      public ActionResult GetProduct()
        {
            //var d = database.GetAll();
            //return View();
            return View(db.Product.ToList());
        }

    }
}