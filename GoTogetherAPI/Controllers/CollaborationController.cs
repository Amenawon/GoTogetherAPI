using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// Allows users to collaborate on trip planning.


namespace GoTogether.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CollaborationController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
