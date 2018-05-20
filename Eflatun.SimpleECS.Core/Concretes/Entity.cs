using Eflatun.SimpleECS.Core.Interfaces;

namespace Eflatun.SimpleECS.Core.Concretes
{
    public class Entity : IEntity
    {
        public int Id { get; }
        
        public Entity(int id)
        {
            Id = id;
        }
    }
}
