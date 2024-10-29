using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// Provides packing tips for the travel destination.

namespace GoTogether.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PackingSuggestionsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
