using Breeder.Dal.Interfaces;
using Breeder.Dal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Breeder.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EntitiesController : ControllerBase
{
    private IEntityDao _EntityDao;
    
    public EntitiesController(IEntityDao entityDao) => _EntityDao = entityDao; 
    
    // GET: api/<Entity>
    [HttpGet]
    public IEnumerable<Entity> GetAll()
    {
        return _EntityDao.GetAll();
    }

    // GET api/<Entity>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<Entity>
    [HttpPost]
    public Entity Post([FromBody] string value)
    {
        Entity entity = new Entity(value);
        Entity addedEntity = _EntityDao.Add(entity);
        return addedEntity;
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
