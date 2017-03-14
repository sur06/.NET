using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using home.Models;

namespace home.Controllers
{
    public class homeController : ApiController
    {
        Result[] homes = new Result[]
        {
           // new Result { id = 1, name = "abc"},
           // new Result { id = 2, name = "def"},
           // new Result { id = 3, name = "ghi"}
        };

        public IEnumerable<Result> GetAllProducts()
        {
            return homes;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var name = homes.FirstOrDefault((p) => p.id == id);
            if (name == null)
            {
                return NotFound();
            }
            return Ok(name);
        }
    }
}

