using Agencija_Back.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agencija_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Users : Controller
    {
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return new List<User>();
        }
    }
}
