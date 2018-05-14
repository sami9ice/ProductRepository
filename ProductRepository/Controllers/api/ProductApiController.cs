using ProductRepository.Models;
using ProductRepository.RepoPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductRepository.Controllers.api
{
    [RoutePrefix("api/product")]
    public class ProductApiController : ApiController
    {
        private readonly ProdRepository repo;
        public ProductApiController()
        {
            repo = new ProdRepository();
        }
        [Route("list")]
        [HttpGet]
        public HttpResponseMessage Display()
        {
            try
            {
                var result = repo.GetAll();
                return Request.CreateResponse<IEnumerable<Product>>(HttpStatusCode.Created, result);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.GatewayTimeout, ex.Message);
            }
        }
    }
}
