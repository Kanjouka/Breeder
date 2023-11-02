using Breeder.Dal.Models;

namespace Breeder.Dal.Interfaces;
public interface IEntityDao
{
    public Entity GeyByName();
    public IEnumerable<Entity> GetAll();
    public Entity Add (Entity entity);
}
