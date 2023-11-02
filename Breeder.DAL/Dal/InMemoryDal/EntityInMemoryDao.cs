using Breeder.Dal.Interfaces;
using Breeder.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeder.Dal.Dal.InMemoryDal;

public class EntityInMemoryDao : IEntityDao
{
    public int Id = 0;
    private List<Entity> _entities;
    public EntityInMemoryDao()
    {
        _entities = new List<Entity> { };
    }

    public Entity Add(Entity entity)
    {
        Id += 1;
        entity.Id = Id;
        _entities.Add(entity);
        return entity;
    }

    public IEnumerable<Entity> GetAll() => _entities;

    public Entity GeyByName()
    {
        throw new NotImplementedException();
    }
}
