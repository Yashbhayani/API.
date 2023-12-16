using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApplication1.Controllers
{
    [Route("api/HomeController")]
    public class HomeController : Controller
    {        
        [Route("index")]
        [HttpGet]
        public async Task<string> Test()
        {
            return "This is just demo";
        }
    }
}
