using Methoda.DAL;
using Methoda.Models;
using Microsoft.AspNetCore.Mvc;

namespace Methoda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        // GET: api/<StatusController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(StatusDAL.getAll());
        }

        // GET api/<StatusController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StatusController>
        [HttpPost]
        public IActionResult Post([FromBody] Status value)
        {
           
            StatusDAL.AddStatus(value);
            return Ok(StatusDAL.getAll());
        }

        // PUT api/<StatusController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StatusController>/5
        [HttpDelete("{name}")]
        public IActionResult Delete(string name)
        {
            StatusDAL.DeleteStatus(name);
            return Ok(StatusDAL.getAll());
        }

        // DELETE api/<StatusController>
        [HttpDelete]
        public IActionResult Delete()
        {
            StatusDAL.Reset();
            return Ok(StatusDAL.getAll());
        }
    }
}
