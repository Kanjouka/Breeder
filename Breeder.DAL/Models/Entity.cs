using Breeder.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeder.Dal.Models;
public class Entity
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Entity(string name) => Name = name;
}
