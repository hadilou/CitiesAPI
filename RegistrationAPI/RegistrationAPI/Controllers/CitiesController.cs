using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RegistrationAPI.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public IActionResult GetCities(){
            var temp = new CitiesDataStore().Cities;
            return Ok(temp);
        }
        [HttpGet("{id}")]
        public IActionResult GetCities(int id){
            var temp = new  CitiesDataStore().Cities.Find(c => c.id == id);
            return temp == null ? NotFound() : (IActionResult)Ok(temp);
        }

    }
}
