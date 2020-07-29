using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            User u = new User();
            u.Id = 1;
            u.Name = "Anuj";
            u.Email = "anuj.goyal@nagarro.com";
            u.Age = 30;
            return u;
        }
    }
}
