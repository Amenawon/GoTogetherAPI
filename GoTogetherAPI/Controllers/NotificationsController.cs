using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// Sends reminders to users about upcoming travel tasks, bookings, and events.

namespace GoTogether.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
