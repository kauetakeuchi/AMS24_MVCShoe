using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AMST4.Store.Shoes.Controllers
{
    [Route("[controller]")]
    public class DisplayController : Controller
    {
        private readonly ILogger<DisplayController> _logger;

        public DisplayController(ILogger<DisplayController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Display()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}