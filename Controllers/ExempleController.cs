using Methoda.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Methoda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExempleController : ControllerBase
    {
        // GET: api/<ExempleController>
        [HttpGet]
        public IActionResult Get()
        {
            //return new string[] { "tzivi", "value2" };
            return Ok(new string ("tzivi" ));
        }

        // GET api/<ExempleController>/5
        [HttpGet("{id}")]
        //[Route("aa/{Id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ExempleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExempleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExempleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
