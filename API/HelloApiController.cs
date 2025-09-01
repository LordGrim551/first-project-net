using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using System;

namespace MyProject.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloApiController : ControllerBase
    {
        [HttpGet("/HelloApi/{id}")]
        public ActionResult<Hello> Index()
        {

            return new Hello
            {
                Id = 1,
                Message = "¡Hola desde la API!",
                CreatedAt = DateTime.Now
            };
        }

        [HttpGet("morning/{id}")]
        public ActionResult<Hello> Morning()
        {
            return new Hello
            {
                Id = 2,
                Message = "¡Buenos días desde la API!",
                CreatedAt = DateTime.Now
            };
        }

        [HttpGet("evening/{id}")]
        public ActionResult<Hello> Evening(int id)
        {
            if (id == 3)
            {
                return new Hello
                {
                    Id = id,
                    Message = "¡Buenas noches desde la API!",
                    CreatedAt = DateTime.Now
                };
            }
            
            else
            {
                return NotFound(new { error = "Id no válido. Debe ser 3." });
            }


        }

    }
}
