using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// Gathers user preferences and stores profiles for personalizing travel suggestions.

namespace GoTogether.API.Controllers
{
    public class UserPreferencesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
