using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

//Provides information about a user’s selected travel destination, including popular sites, dining options, hotels, and events.
namespace GoTogether.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DestinationController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
