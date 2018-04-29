using SimpleECS.Interfaces;

namespace SimpleECS.Concretes
{
    public struct Entity : IEntity
    {
        public int Id { get; }
        
        public Entity(int id)
        {
            Id = id;
        }
    }
}
