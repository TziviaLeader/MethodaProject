using Methoda.DAL;
using Methoda.Models;
using Microsoft.AspNetCore.Mvc;


namespace Methoda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransitionController : ControllerBase
    {

        // GET: api/<TrasitionController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(TransitionDAL.getAll());
        }

        // GET api/<TrasitionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TrasitionController>
        [HttpPost]
        public IActionResult Post([FromBody] Transition value)
        {
            TransitionDAL.AddTransition(value);
            return Ok(TransitionDAL.getAll());
        }

        // PUT api/<TrasitionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TrasitionController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string name)
        {
            TransitionDAL.DeleteTransition(name);
            return Ok(TransitionDAL.getAll());
        }

        // DELETE api/<TrasitionController>
        [HttpDelete]
        public IActionResult Delete()
        {
            TransitionDAL.Reset();
            return Ok(TransitionDAL.getAll());
        }
    }
}
