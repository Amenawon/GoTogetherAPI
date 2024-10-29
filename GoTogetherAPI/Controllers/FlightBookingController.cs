using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// Handles flight information, bookings, and other transport options like car rentals.

namespace GoTogether.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightBookingController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
