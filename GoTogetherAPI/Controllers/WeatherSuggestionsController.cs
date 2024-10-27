using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// Provides weather forecasts  for the travel destination.

namespace GoTogether.API.Controllers
{
    public class WeatherSuggestionsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
