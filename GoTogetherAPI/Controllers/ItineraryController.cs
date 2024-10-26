using System;
using System.Collections;
using System.Collections.Generic;
using GoTogether.DataAccess.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoTogether.API.Controllers.Itinerary
{
    public class ItineraryController : Controller
    {
        [HttpPost]
        public IEnumerable<Itinerary> Create()
        {
           
        }
        [HttpGet]
        public IEnumerable<Itinerary> Get()
        {

        }
        [HttpPut]
        public IEnumerable Update()
        {

        }
        [HttpDelete]
        public IEnumerable Delete()
        {

        }
    }
}
