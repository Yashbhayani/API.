using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace MVCWebApplication2.Controllers
{
    [Route("home")]
    public class HomeController : ApiController
    {
        [Route("Yash")]
        [HttpGet]
        public IEnumerable Yash()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
