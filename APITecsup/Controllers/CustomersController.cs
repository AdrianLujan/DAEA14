using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace APITecsup.Controllers
{
    /// <summary>
    /// customer controller class for testing security token
    /// </summary>
    [System.Web.Http.Authorize]
    [System.Web.Http.RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetId(int id)
        {
            var customerFake = "customer-fake";
            return Ok(customerFake);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetAll()
        {
            var customersFake = new string[] { "customer-1", "customer-2", "customer-3" };
            return Ok(customersFake);
        }
    }
}