using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegistrationAPI.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RegistrationAPI.Controllers
{
    [Route("api/cities")]
    public class PointOfInterestController : Controller
    {
        [HttpGet("{cityID}/pointsofinterests")]
        public IActionResult GetPointsOfInterest(int cityID)
        {
            var temp = new CitiesDataStore().Cities.Find(c => c.id == cityID);

            if (temp == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(temp.pointOfInterests);
            }
        }
        [HttpGet("{cityID}/pointsofinterests/{pointOfInterestID}")]
        public IActionResult GetPointsOfInterest(int cityID,int pointOfInterestID)
        {
            var temp = new CitiesDataStore().Cities.Find(c => c.id == cityID);

            if (temp == null)
            {
                return NotFound();
            }
            else
            {
                if (temp.pointOfInterests  == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(temp.pointOfInterests.Find(c => c.id == pointOfInterestID));
                }
            }
        }
    }
}
