using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agencija_Back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Home : ControllerBase
    {


        [HttpGet]
        public IActionResult GetPSPUrl()
        {
            return Ok(new { link = "http://localhost:3001/home" });
        }
        [HttpPost]
        [Route("/paid-registration")]
        public IActionResult PaidRegistration(string id)
        {
            //find company with given id in database and change property 'paid' to true
            return Ok(new { link = "http://localhost:3001/home" });
        }
    }
}
