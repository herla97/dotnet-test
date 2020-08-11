using System;
using System.Collections.Generic;
using System.Linq;
using donet_test.Models;
using Microsoft.AspNetCore.Mvc;

namespace donet_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController: ControllerBase
    {
        // private static Character knight = new Character();
        private static List<Character> characters = new List<Character> {
            new Character(),
            // new Character{Id = System.Guid.NewGuid(), Name = "Salvador"}
            new Character{Id = Guid.Parse("f545a9ef-1949-485d-8358-3cd27cc225f9"), Name = "Salvador"}
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(Guid id)
        { 
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

    }
}