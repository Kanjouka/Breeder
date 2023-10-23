using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Breeder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Entity : ControllerBase
    {
        // GET: api/<Entity>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Entity>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Entity>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Entity>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Entity>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
